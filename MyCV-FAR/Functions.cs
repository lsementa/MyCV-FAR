using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static MyCVToolkit.Settings;
using Excel = Microsoft.Office.Interop.Excel;

namespace MyCVToolkit
{
    internal class Functions
    {

        // Check BUIDs
        public static List<string> CheckBUIDs(Excel.Range rangeToProcess)
        {
            List<string> finalBuidList = new List<string>();

            if (rangeToProcess == null) return finalBuidList;

            try
            {
                object[,] columnValues = rangeToProcess.Value2 as object[,];
                if (columnValues == null) return finalBuidList;

                List<string> allBuids = new List<string>();
                Dictionary<int, string> rowToBuidMap = new Dictionary<int, string>();
                HashSet<string> buidsForDbCheck = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                // Collect all BUIDs (keep duplicates)
                for (int i = 1; i <= columnValues.GetLength(0); i++)
                {
                    object cellValueObj = columnValues[i, 1];
                    if (cellValueObj != null && !string.IsNullOrWhiteSpace(cellValueObj.ToString()))
                    {
                        string buid = cellValueObj.ToString().Trim();
                        if (buid.StartsWith("U", StringComparison.OrdinalIgnoreCase))
                        {
                            allBuids.Add(buid);
                            rowToBuidMap[i] = buid;
                            buidsForDbCheck.Add(buid); // Only distinct values for DB
                        }
                    }
                }

                if (allBuids.Count == 0)
                {
                    MessageBox.Show("No BUIDs found.", "Check Complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return finalBuidList;
                }

                // Get existing BUIDs from DB (only distinct set)
                HashSet<string> existingBuids = GetExistingBUIDsFromDB(buidsForDbCheck);

                // Track missing
                List<string> missingBuids = new List<string>();

                foreach (var kvp in rowToBuidMap)
                {
                    if (!existingBuids.Contains(kvp.Value))
                    {
                        Excel.Range cell = (Excel.Range)rangeToProcess.Cells[kvp.Key, 1];
                        cell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                        missingBuids.Add(kvp.Value);

                        // Scroll to and select the cell
                        cell.Application.Goto(cell, true);
                    }
                }

                // Final result (duplicates kept)
                if (missingBuids.Count == 0)
                {
                    finalBuidList = allBuids; // Keeps duplicates & order
                }
                else
                {
                    MessageBox.Show(
                        "Some BUIDs were not found (highlighted in yellow). " +
                        "If you can't find the correct one, delete or replace it so it doesn't start with 'U' and re-run.",
                        "Check Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    finalBuidList.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return finalBuidList;
        }


        // Check the reporting database
        private static HashSet<string> GetExistingBUIDsFromDB(HashSet<string> buids)
        {
            // Load settings
            UserSettings settings = Settings.LoadUserSettingsFromXml();
            // Decrypt password
            string password = EncryptionHelper.DecryptString(settings.Password);

            var existing = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            if (buids.Count == 0)
                return existing;

            string connectionString = $"Server={settings.Server};Database={settings.Database};User ID={settings.Username};Password={password};Connection Timeout=5;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Build the IN clause with quoted BUIDs
                string inClause = string.Join(", ", buids.Select(b => $"'{b.Replace("'", "''")}'"));

                string sql = $"SELECT [Proprietary ID] FROM [User] WHERE [Proprietary ID] IN ({inClause})";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            existing.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return existing;
        }

        // Create Users list
        public static void CreateUsersList()
        {
            // Load settings
            UserSettings settings = Settings.LoadUserSettingsFromXml();
            string savePath = settings.UserFiles ?? string.Empty;

            Excel.Application excelApp = Globals.ThisAddIn.Application;
            Excel.Workbook activeWorkbook = excelApp.ActiveWorkbook;

            if (activeWorkbook == null)
                return;

            Excel.Worksheet activeSheet = excelApp.ActiveSheet;
            Excel.Range rangeToProcess = null;

            // Prompt the user to select BUIDs
            object rangeInput = excelApp.InputBox(
                "Select the range of BUIDs:",
                "Create Users List",
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 8);
           
            // Handle InputBox cancellation
            if (rangeInput is bool && (bool)rangeInput == false)
                return;

            rangeToProcess = rangeInput as Excel.Range;
            if (rangeToProcess == null)
                return;

            try
            {
                // Get the validated BUIDs
                List<string> buids = CheckBUIDs(rangeToProcess);
                if (buids == null || buids.Count == 0)
                    return;

                // Ensure save path ends with slash
                if (!savePath.EndsWith("\\"))
                    savePath += "\\";

                // Ask the user for file name
                SaveFileDialog sfd = new SaveFileDialog
                {
                    InitialDirectory = savePath,
                    Filter = "CSV files (*.csv)|*.csv",
                    Title = "Save Users List",
                    FileName = "FAR Users.csv"
                };

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                string filePath = sfd.FileName;

                // Create CSV content
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("User ID,Username,Proprietary ID");

                foreach (var buid in buids)
                {
                    sb.AppendLine($",,{buid}"); // Leave User ID & Username blank
                }

                // Save file
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Create Reviewers list
        public static void CreateReviewersList()
        {
            // Load settings
            UserSettings settings = Settings.LoadUserSettingsFromXml();
            string savePath = settings.ReviewerFiles ?? string.Empty;

            Excel.Application excelApp = Globals.ThisAddIn.Application;
            Excel.Workbook activeWorkbook = excelApp.ActiveWorkbook;
            if (activeWorkbook == null)
                return;

            try
            {
                // Prompt for Reviewee BUIDs
                object revieweeInput = excelApp.InputBox(
                    "Select the range of BUIDs for the Reviewees:",
                    "Reviewee Range Selector",
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 8);

                if (revieweeInput is bool && (bool)revieweeInput == false)
                    return;

                Excel.Range revieweeRange = revieweeInput as Excel.Range;
                if (revieweeRange == null)
                    return;

                List<string> revieweeBuids = CheckBUIDs(revieweeRange);
                if (revieweeBuids == null || revieweeBuids.Count == 0)
                    return;

                // Prompt for Reviewer BUIDs
                object reviewerInput = excelApp.InputBox(
                    "Select the range of BUIDs for the Reviewers:",
                    "Reviewer Range Selector",
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 8);

                if (reviewerInput is bool && (bool)reviewerInput == false)
                    return;

                Excel.Range reviewerRange = reviewerInput as Excel.Range;
                if (reviewerRange == null)
                    return;

                List<string> reviewerBuids = CheckBUIDs(reviewerRange);
                if (reviewerBuids == null || reviewerBuids.Count == 0)
                    return;

                // Length check
                if (revieweeBuids.Count != reviewerBuids.Count)
                {
                    MessageBox.Show(
                        $"The number of reviewees ({revieweeBuids.Count}) does not match the number of reviewers ({reviewerBuids.Count}).",
                        "Mismatch Detected",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Ensure save path ends with slash
                if (!savePath.EndsWith("\\") && !savePath.EndsWith("/"))
                    savePath += "\\";

                // Prompt for filename
                SaveFileDialog sfd = new SaveFileDialog
                {
                    InitialDirectory = savePath,
                    Filter = "CSV files (*.csv)|*.csv",
                    Title = "Save Reviewers List",
                    FileName = "FAR Reviewers.csv"
                };

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                string filePath = sfd.FileName;

                // Create CSV
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Reviewee User ID,Reviewee Username,Reviewee Proprietary ID,Reviewer User ID,Reviewer Username,Reviewer Proprietary ID");

                int maxCount = Math.Max(revieweeBuids.Count, reviewerBuids.Count);
                for (int i = 0; i < maxCount; i++)
                {
                    string revieweeId = i < revieweeBuids.Count ? revieweeBuids[i] : string.Empty;
                    string reviewerId = i < reviewerBuids.Count ? reviewerBuids[i] : string.Empty;
                    sb.AppendLine($",,{revieweeId},,,{reviewerId}");
                }

                // Save CSV
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Check proposals for blank submission date
        public static void CheckProposals()
        {
            Excel.Application excelApp = Globals.ThisAddIn.Application;
            Excel.Workbook activeWorkbook = excelApp.ActiveWorkbook;
            if (activeWorkbook == null)
                return;

            // Make sure we're on the mycv_grants worksheet
            if (!(activeWorkbook.ActiveSheet is Excel.Worksheet ws) ||
                !string.Equals(ws.Name, "mycv_grants", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("This check only runs on the mycv_grants sheet. Open the correct CSV file.",
                    "Check Proposals", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Clear any existing filter so criteria don't stack on top of old ones
            if (ws.AutoFilterMode)
                ws.AutoFilterMode = false;

            // Build the filter range from A1 to the last used row, at least through column L
            Excel.Range used = ws.UsedRange;
            int lastRow = used.Row + used.Rows.Count - 1;
            int lastCol = Math.Max(12, used.Column + used.Columns.Count - 1);
            Excel.Range filterRange = ws.Range[ws.Cells[1, 1], ws.Cells[lastRow, lastCol]];

            // Column A: IDs ending in _PROP
            filterRange.AutoFilter(1, "*_PROP",
                Excel.XlAutoFilterOperator.xlAnd, Type.Missing, true);

            // Column L: blank OR 1/1/1900 (date serial 1, so "<2" catches it)
            filterRange.AutoFilter(12, "=",
                Excel.XlAutoFilterOperator.xlOr, "<2", true);

            // Count visible cells in column A of the filter range (header included)
            Excel.Range visibleCells = ((Excel.Range)filterRange.Columns[1])
                .SpecialCells(Excel.XlCellType.xlCellTypeVisible);

            if (visibleCells.Count <= 1)
            {
                ws.AutoFilterMode = false;
                MessageBox.Show("There are no blank or 1/1/1900 proposal submission dates.",
                    "Check Proposals", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}