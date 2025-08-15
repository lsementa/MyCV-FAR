using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MyCVToolkit.Settings;

namespace MyCVToolkit
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();

            // Add event handlers for enter key search
            TbFirstName.KeyDown += TbName_KeyDown;
            TbLastName.KeyDown += TbName_KeyDown;
        }

        // On Load
        private void SearchForm_Load(object sender, EventArgs e)
        {
            ClearForm();

            // DataGridView configuration
            DGSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGSearch.RowHeadersVisible = false;
        }

        // Search button
        private void SearchForm_Search_Click(object sender, EventArgs e)
        {
            SearchUser();
        }

        // Search function
        private void SearchUser()
        {
            // Prevent search if both are empty
            if (string.IsNullOrEmpty(TbFirstName.Text) && string.IsNullOrEmpty(TbLastName.Text))
            {
                return;
            }

            try
            {
                // Load settings
                UserSettings settings = Settings.LoadUserSettingsFromXml();
                // Decrypt password
                string password = EncryptionHelper.DecryptString(settings.Password);

                // Search criteria
                string firstname = TbFirstName.Text.Trim();
                string lastname = TbLastName.Text.Trim();

                // Connection string
                string connectionString = $"Server={settings.Server};Database={settings.Database};User ID={settings.Username};Password={password};Connection Timeout=5;";

                // SQL query with parameters
                string query = @"
            SELECT 
                [First Name], 
                [Last Name], 
                [Username], 
                [Proprietary ID], 
                [Primary Group Descriptor]
            FROM [User]
            WHERE [First Name] LIKE @FirstName
              AND [Last Name] LIKE @LastName
            ORDER BY [Last Name], [First Name];
        ";

                // Fill DataGridView
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Using LIKE with wildcards for partial matching
                    cmd.Parameters.AddWithValue("@FirstName", "%" + firstname + "%");
                    cmd.Parameters.AddWithValue("@LastName", "%" + lastname + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    conn.Open();
                    adapter.Fill(dt);

                    DGSearch.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear function
        private void ClearForm()
        {
            TbFirstName.Clear();
            TbLastName.Clear();

            // Clear DatagridView
            DGSearch.DataSource = null;
        }

        // Clear button
        private void SearchForm_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Close button
        private void SearchForm_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Search user if Enter key is pressed
        private void TbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SearchUser();
            }
        }

    }
}
