namespace MyCVToolkit
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SettingsForm_BrowseReviewers = new System.Windows.Forms.Button();
            this.SettingsForm_BrowseUsers = new System.Windows.Forms.Button();
            this.TbReviewerFiles = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbUserFiles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SettingsForm_Cancel = new System.Windows.Forms.Button();
            this.SettingsForm_Save = new System.Windows.Forms.Button();
            this.SettingsForm_Test = new System.Windows.Forms.Button();
            this.TbDatabase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbDatabase);
            this.groupBox1.Controls.Add(this.SettingsForm_Test);
            this.groupBox1.Controls.Add(this.TbPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporting Database";
            // 
            // TbPassword
            // 
            this.TbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPassword.Location = new System.Drawing.Point(47, 329);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(273, 35);
            this.TbPassword.TabIndex = 7;
            this.TbPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Password:";
            // 
            // TbUsername
            // 
            this.TbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbUsername.Location = new System.Drawing.Point(47, 249);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(273, 35);
            this.TbUsername.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Username:";
            // 
            // TbServer
            // 
            this.TbServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbServer.Location = new System.Drawing.Point(47, 84);
            this.TbServer.Name = "TbServer";
            this.TbServer.Size = new System.Drawing.Size(446, 35);
            this.TbServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Server:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SettingsForm_BrowseReviewers);
            this.groupBox2.Controls.Add(this.SettingsForm_BrowseUsers);
            this.groupBox2.Controls.Add(this.TbReviewerFiles);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TbUserFiles);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folders";
            // 
            // SettingsForm_BrowseReviewers
            // 
            this.SettingsForm_BrowseReviewers.Location = new System.Drawing.Point(503, 171);
            this.SettingsForm_BrowseReviewers.Name = "SettingsForm_BrowseReviewers";
            this.SettingsForm_BrowseReviewers.Size = new System.Drawing.Size(113, 43);
            this.SettingsForm_BrowseReviewers.TabIndex = 14;
            this.SettingsForm_BrowseReviewers.Text = "Browse";
            this.SettingsForm_BrowseReviewers.UseVisualStyleBackColor = true;
            this.SettingsForm_BrowseReviewers.Click += new System.EventHandler(this.SettingsForm_BrowseReviewers_Click);
            // 
            // SettingsForm_BrowseUsers
            // 
            this.SettingsForm_BrowseUsers.Location = new System.Drawing.Point(503, 77);
            this.SettingsForm_BrowseUsers.Name = "SettingsForm_BrowseUsers";
            this.SettingsForm_BrowseUsers.Size = new System.Drawing.Size(113, 43);
            this.SettingsForm_BrowseUsers.TabIndex = 11;
            this.SettingsForm_BrowseUsers.Text = "Browse";
            this.SettingsForm_BrowseUsers.UseVisualStyleBackColor = true;
            this.SettingsForm_BrowseUsers.Click += new System.EventHandler(this.SettingsForm_BrowseUsers_Click);
            // 
            // TbReviewerFiles
            // 
            this.TbReviewerFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbReviewerFiles.Location = new System.Drawing.Point(48, 176);
            this.TbReviewerFiles.Name = "TbReviewerFiles";
            this.TbReviewerFiles.Size = new System.Drawing.Size(449, 35);
            this.TbReviewerFiles.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "&Reviewer Files:";
            // 
            // TbUserFiles
            // 
            this.TbUserFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbUserFiles.Location = new System.Drawing.Point(48, 82);
            this.TbUserFiles.Name = "TbUserFiles";
            this.TbUserFiles.Size = new System.Drawing.Size(449, 35);
            this.TbUserFiles.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "User &Files:";
            // 
            // SettingsForm_Cancel
            // 
            this.SettingsForm_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsForm_Cancel.Location = new System.Drawing.Point(518, 741);
            this.SettingsForm_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsForm_Cancel.Name = "SettingsForm_Cancel";
            this.SettingsForm_Cancel.Size = new System.Drawing.Size(164, 56);
            this.SettingsForm_Cancel.TabIndex = 16;
            this.SettingsForm_Cancel.Text = "Cancel";
            this.SettingsForm_Cancel.UseVisualStyleBackColor = true;
            this.SettingsForm_Cancel.Click += new System.EventHandler(this.SettingsForm_Cancel_Click);
            // 
            // SettingsForm_Save
            // 
            this.SettingsForm_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsForm_Save.Location = new System.Drawing.Point(330, 741);
            this.SettingsForm_Save.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsForm_Save.Name = "SettingsForm_Save";
            this.SettingsForm_Save.Size = new System.Drawing.Size(164, 56);
            this.SettingsForm_Save.TabIndex = 15;
            this.SettingsForm_Save.Text = "Save";
            this.SettingsForm_Save.UseVisualStyleBackColor = true;
            this.SettingsForm_Save.Click += new System.EventHandler(this.SettingsForm_Save_Click);
            // 
            // SettingsForm_Test
            // 
            this.SettingsForm_Test.Location = new System.Drawing.Point(390, 324);
            this.SettingsForm_Test.Name = "SettingsForm_Test";
            this.SettingsForm_Test.Size = new System.Drawing.Size(226, 43);
            this.SettingsForm_Test.TabIndex = 8;
            this.SettingsForm_Test.Text = "Test";
            this.SettingsForm_Test.UseVisualStyleBackColor = true;
            this.SettingsForm_Test.Click += new System.EventHandler(this.SettingsForm_Test_Click);
            // 
            // TbDatabase
            // 
            this.TbDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDatabase.Location = new System.Drawing.Point(47, 165);
            this.TbDatabase.Name = "TbDatabase";
            this.TbDatabase.Size = new System.Drawing.Size(446, 35);
            this.TbDatabase.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "&Database:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 826);
            this.Controls.Add(this.SettingsForm_Cancel);
            this.Controls.Add(this.SettingsForm_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbReviewerFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbUserFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SettingsForm_BrowseReviewers;
        private System.Windows.Forms.Button SettingsForm_BrowseUsers;
        private System.Windows.Forms.Button SettingsForm_Cancel;
        private System.Windows.Forms.Button SettingsForm_Save;
        private System.Windows.Forms.Button SettingsForm_Test;
        private System.Windows.Forms.TextBox TbDatabase;
        private System.Windows.Forms.Label label6;
    }
}