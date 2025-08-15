using Microsoft.Office.Tools.Ribbon;

namespace MyCVToolkit
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        // User settings
        private void BtnSettings_Click(object sender, RibbonControlEventArgs e)
        {
            SettingsForm form1 = new SettingsForm();
            form1.ShowDialog();
        }

        // Create Users list
        private void BtnUsersCSV_Click(object sender, RibbonControlEventArgs e)
        {
            Functions.CreateUsersList();
        }

        // Create Reviewers list
        private void BtnReviewersCSV_Click(object sender, RibbonControlEventArgs e)
        {
            Functions.CreateReviewersList();
        }
    }
}
