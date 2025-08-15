using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MyCVToolkit.Properties;
using static MyCVToolkit.Settings;

namespace MyCVToolkit
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        // On Load
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Load settings
            UserSettings settings = Settings.LoadUserSettingsFromXml();

            TbServer.Text = settings.Server;
            TbDatabase.Text = settings.Database;
            TbUsername.Text = settings.Username;
            TbPassword.Text = EncryptionHelper.DecryptString(settings.Password);
            TbUserFiles.Text = settings.UserFiles;
            TbReviewerFiles.Text = settings.ReviewerFiles;
           
        }

        // Browse to folder for User CSVs
        private void SettingsForm_BrowseUsers_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder";
                folderDialog.ShowNewFolderButton = true;

                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    TbUserFiles.Text = folderDialog.SelectedPath;
                }
            }
        }

        // Browse to folder for Reviewer CSVs
        private void SettingsForm_BrowseReviewers_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder";
                folderDialog.ShowNewFolderButton = true;

                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    TbReviewerFiles.Text = folderDialog.SelectedPath;
                }
            }

        }

        // Close button
        private void SettingsForm_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Save button
        private void SettingsForm_Save_Click(object sender, EventArgs e)
        {
            // Load current settings from XML
            UserSettings currentSettings = Settings.LoadUserSettingsFromXml();

            // Update only the forms settings
            currentSettings.Server = TbServer.Text;
            currentSettings.Database = TbDatabase.Text;
            currentSettings.Username = TbUsername.Text;
            currentSettings.Password = EncryptionHelper.EncryptString(TbPassword.Text);
            currentSettings.UserFiles = TbUserFiles.Text;
            currentSettings.ReviewerFiles = TbReviewerFiles.Text;

            // Save all settings
            Settings.SaveUserSettingsToXml(currentSettings);

            // Close the form
            this.Close();
        }

        // Test button for checking reporting database
        private void SettingsForm_Test_Click(object sender, EventArgs e)
        {
            string server = TbServer.Text.Trim();
            string database = TbDatabase.Text.Trim();
            string username = TbUsername.Text.Trim();
            string password = TbPassword.Text.Trim();

            // Build a basic SQL Server connection string
            string connectionString = $"Server={server};Database={database};User ID={username};Password={password};Connection Timeout=5;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection successful!", "Reporting Database Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection failed:\n{ex.Message}", "Reporting Database Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
