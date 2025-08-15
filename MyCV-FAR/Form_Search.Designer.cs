namespace MyCVToolkit
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DGSearch = new System.Windows.Forms.DataGridView();
            this.SearchForm_Cancel = new System.Windows.Forms.Button();
            this.SearchForm_Clear = new System.Windows.Forms.Button();
            this.SearchForm_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // TbLastName
            // 
            this.TbLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbLastName.Location = new System.Drawing.Point(360, 58);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(291, 31);
            this.TbLastName.TabIndex = 3;
            // 
            // TbFirstName
            // 
            this.TbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbFirstName.Location = new System.Drawing.Point(32, 58);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(291, 31);
            this.TbFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "&First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "&Last Name:";
            // 
            // DGSearch
            // 
            this.DGSearch.AllowUserToAddRows = false;
            this.DGSearch.AllowUserToDeleteRows = false;
            this.DGSearch.AllowUserToResizeRows = false;
            this.DGSearch.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGSearch.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSearch.Location = new System.Drawing.Point(32, 117);
            this.DGSearch.MultiSelect = false;
            this.DGSearch.Name = "DGSearch";
            this.DGSearch.ReadOnly = true;
            this.DGSearch.RowHeadersWidth = 82;
            this.DGSearch.RowTemplate.Height = 33;
            this.DGSearch.Size = new System.Drawing.Size(981, 424);
            this.DGSearch.TabIndex = 4;
            // 
            // SearchForm_Cancel
            // 
            this.SearchForm_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForm_Cancel.Location = new System.Drawing.Point(849, 561);
            this.SearchForm_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.SearchForm_Cancel.Name = "SearchForm_Cancel";
            this.SearchForm_Cancel.Size = new System.Drawing.Size(164, 56);
            this.SearchForm_Cancel.TabIndex = 7;
            this.SearchForm_Cancel.Text = "Cancel";
            this.SearchForm_Cancel.UseVisualStyleBackColor = true;
            this.SearchForm_Cancel.Click += new System.EventHandler(this.SearchForm_Cancel_Click);
            // 
            // SearchForm_Clear
            // 
            this.SearchForm_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForm_Clear.Location = new System.Drawing.Point(661, 561);
            this.SearchForm_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.SearchForm_Clear.Name = "SearchForm_Clear";
            this.SearchForm_Clear.Size = new System.Drawing.Size(164, 56);
            this.SearchForm_Clear.TabIndex = 6;
            this.SearchForm_Clear.Text = "Clear";
            this.SearchForm_Clear.UseVisualStyleBackColor = true;
            this.SearchForm_Clear.Click += new System.EventHandler(this.SearchForm_Clear_Click);
            // 
            // SearchForm_Search
            // 
            this.SearchForm_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForm_Search.Location = new System.Drawing.Point(474, 561);
            this.SearchForm_Search.Margin = new System.Windows.Forms.Padding(4);
            this.SearchForm_Search.Name = "SearchForm_Search";
            this.SearchForm_Search.Size = new System.Drawing.Size(164, 56);
            this.SearchForm_Search.TabIndex = 5;
            this.SearchForm_Search.Text = "Search";
            this.SearchForm_Search.UseVisualStyleBackColor = true;
            this.SearchForm_Search.Click += new System.EventHandler(this.SearchForm_Search_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 640);
            this.Controls.Add(this.SearchForm_Search);
            this.Controls.Add(this.SearchForm_Cancel);
            this.Controls.Add(this.SearchForm_Clear);
            this.Controls.Add(this.DGSearch);
            this.Controls.Add(this.TbLastName);
            this.Controls.Add(this.TbFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Users";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGSearch;
        private System.Windows.Forms.Button SearchForm_Cancel;
        private System.Windows.Forms.Button SearchForm_Clear;
        private System.Windows.Forms.Button SearchForm_Search;
    }
}