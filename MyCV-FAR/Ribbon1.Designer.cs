namespace MyCVToolkit
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Home = this.Factory.CreateRibbonTab();
            this.MyCVGroup = this.Factory.CreateRibbonGroup();
            this.BtnSettings = this.Factory.CreateRibbonButton();
            this.BtnUsersCSV = this.Factory.CreateRibbonButton();
            this.BtnReviewersCSV = this.Factory.CreateRibbonButton();
            this.BtnUsers = this.Factory.CreateRibbonSplitButton();
            this.BtnSearch = this.Factory.CreateRibbonButton();
            this.Home.SuspendLayout();
            this.MyCVGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Home.ControlId.OfficeId = "TabHome";
            this.Home.Groups.Add(this.MyCVGroup);
            this.Home.Label = "TabHome";
            this.Home.Name = "Home";
            // 
            // MyCVGroup
            // 
            this.MyCVGroup.Items.Add(this.BtnSettings);
            this.MyCVGroup.Items.Add(this.BtnSearch);
            this.MyCVGroup.Items.Add(this.BtnUsers);
            this.MyCVGroup.Label = "MyCV FAR";
            this.MyCVGroup.Name = "MyCVGroup";
            // 
            // BtnSettings
            // 
            this.BtnSettings.Label = "Settings";
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.OfficeImageId = "CurrentViewSettings";
            this.BtnSettings.ShowImage = true;
            this.BtnSettings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnSettings_Click);
            // 
            // BtnUsersCSV
            // 
            this.BtnUsersCSV.Label = "Create &Users";
            this.BtnUsersCSV.Name = "BtnUsersCSV";
            this.BtnUsersCSV.OfficeImageId = "Head";
            this.BtnUsersCSV.ShowImage = true;
            this.BtnUsersCSV.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnUsersCSV_Click);
            // 
            // BtnReviewersCSV
            // 
            this.BtnReviewersCSV.Label = "Create &Reviewers";
            this.BtnReviewersCSV.Name = "BtnReviewersCSV";
            this.BtnReviewersCSV.OfficeImageId = "QuickSearchNotToCcMe";
            this.BtnReviewersCSV.ShowImage = true;
            this.BtnReviewersCSV.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnReviewersCSV_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.Items.Add(this.BtnUsersCSV);
            this.BtnUsers.Items.Add(this.BtnReviewersCSV);
            this.BtnUsers.Label = "Import File";
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.OfficeImageId = "Head";
            this.BtnUsers.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnUsers_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Label = "Search User";
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.OfficeImageId = "InstantSearch";
            this.BtnSearch.ShowImage = true;
            this.BtnSearch.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnSearch_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.Home);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.MyCVGroup.ResumeLayout(false);
            this.MyCVGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Home;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup MyCVGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnSettings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnUsersCSV;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnReviewersCSV;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton BtnUsers;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnSearch;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
