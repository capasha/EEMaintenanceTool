namespace EEFixer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LogGroupBox = new System.Windows.Forms.GroupBox();
            this.ToolGroupBox = new System.Windows.Forms.GroupBox();
            this.DelFButton = new System.Windows.Forms.Button();
            this.EEUJoinButton = new System.Windows.Forms.Button();
            this.UniverseLabel = new System.Windows.Forms.Label();
            this.BetaLabel = new System.Windows.Forms.Label();
            this.FavoritesCountLabel = new System.Windows.Forms.Label();
            this.FavoritesLabel = new System.Windows.Forms.Label();
            this.FavoritesGroupBox = new System.Windows.Forms.GroupBox();
            this.FavoritesListView = new System.Windows.Forms.ListView();
            this.FavoritesNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FavoritesIDColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EEStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.FlashCLabel = new System.Windows.Forms.Label();
            this.GameOnLabel = new System.Windows.Forms.Label();
            this.GameELabel = new System.Windows.Forms.Label();
            this.FlashCPictureBox = new System.Windows.Forms.PictureBox();
            this.UniversePictureBox = new System.Windows.Forms.PictureBox();
            this.BetaPictureBox = new System.Windows.Forms.PictureBox();
            this.GameOnPictureBox = new System.Windows.Forms.PictureBox();
            this.GameEPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FavBackupGroupBox = new System.Windows.Forms.GroupBox();
            this.FavBackupListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FavBackupCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginGroupBox.SuspendLayout();
            this.LogGroupBox.SuspendLayout();
            this.ToolGroupBox.SuspendLayout();
            this.FavoritesGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.EEStatusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlashCPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniversePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOnPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameEPictureBox)).BeginInit();
            this.FavBackupGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.ConnectButton);
            this.LoginGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.EmailTextBox);
            this.LoginGroupBox.Controls.Add(this.EmailLabel);
            this.LoginGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupBox.Location = new System.Drawing.Point(12, 41);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(200, 155);
            this.LoginGroupBox.TabIndex = 0;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(17, 116);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(17, 90);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(168, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(14, 74);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(65, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(17, 39);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(168, 20);
            this.EmailTextBox.TabIndex = 0;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(14, 23);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email:";
            // 
            // LogRichTextBox
            // 
            this.LogRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.LogRichTextBox.Name = "LogRichTextBox";
            this.LogRichTextBox.Size = new System.Drawing.Size(246, 130);
            this.LogRichTextBox.TabIndex = 1;
            this.LogRichTextBox.Text = "";
            // 
            // LogGroupBox
            // 
            this.LogGroupBox.Controls.Add(this.LogRichTextBox);
            this.LogGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogGroupBox.Location = new System.Drawing.Point(218, 41);
            this.LogGroupBox.Name = "LogGroupBox";
            this.LogGroupBox.Size = new System.Drawing.Size(260, 155);
            this.LogGroupBox.TabIndex = 2;
            this.LogGroupBox.TabStop = false;
            this.LogGroupBox.Text = "Log:";
            // 
            // ToolGroupBox
            // 
            this.ToolGroupBox.Controls.Add(this.FavBackupCheckBox);
            this.ToolGroupBox.Controls.Add(this.DelFButton);
            this.ToolGroupBox.Controls.Add(this.EEUJoinButton);
            this.ToolGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolGroupBox.Location = new System.Drawing.Point(484, 41);
            this.ToolGroupBox.Name = "ToolGroupBox";
            this.ToolGroupBox.Size = new System.Drawing.Size(260, 155);
            this.ToolGroupBox.TabIndex = 3;
            this.ToolGroupBox.TabStop = false;
            this.ToolGroupBox.Text = "Tools";
            // 
            // DelFButton
            // 
            this.DelFButton.Enabled = false;
            this.DelFButton.Image = global::EEFixer.Properties.Resources.delete;
            this.DelFButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DelFButton.Location = new System.Drawing.Point(137, 19);
            this.DelFButton.Name = "DelFButton";
            this.DelFButton.Size = new System.Drawing.Size(94, 23);
            this.DelFButton.TabIndex = 6;
            this.DelFButton.Text = "Flash Cookie";
            this.DelFButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelFButton.UseVisualStyleBackColor = true;
            this.DelFButton.Click += new System.EventHandler(this.DelFButton_Click);
            // 
            // EEUJoinButton
            // 
            this.EEUJoinButton.Enabled = false;
            this.EEUJoinButton.Location = new System.Drawing.Point(6, 19);
            this.EEUJoinButton.Name = "EEUJoinButton";
            this.EEUJoinButton.Size = new System.Drawing.Size(101, 23);
            this.EEUJoinButton.TabIndex = 5;
            this.EEUJoinButton.Text = "Sign Up to EEU";
            this.EEUJoinButton.UseVisualStyleBackColor = true;
            this.EEUJoinButton.Click += new System.EventHandler(this.EEUJoinButton_Click);
            // 
            // UniverseLabel
            // 
            this.UniverseLabel.AutoSize = true;
            this.UniverseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniverseLabel.Location = new System.Drawing.Point(16, 154);
            this.UniverseLabel.Name = "UniverseLabel";
            this.UniverseLabel.Size = new System.Drawing.Size(61, 13);
            this.UniverseLabel.TabIndex = 7;
            this.UniverseLabel.Text = "Universe:";
            // 
            // BetaLabel
            // 
            this.BetaLabel.AutoSize = true;
            this.BetaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetaLabel.Location = new System.Drawing.Point(16, 127);
            this.BetaLabel.Name = "BetaLabel";
            this.BetaLabel.Size = new System.Drawing.Size(37, 13);
            this.BetaLabel.TabIndex = 3;
            this.BetaLabel.Text = "Beta:";
            // 
            // FavoritesCountLabel
            // 
            this.FavoritesCountLabel.AutoSize = true;
            this.FavoritesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavoritesCountLabel.Location = new System.Drawing.Point(75, 16);
            this.FavoritesCountLabel.Name = "FavoritesCountLabel";
            this.FavoritesCountLabel.Size = new System.Drawing.Size(14, 13);
            this.FavoritesCountLabel.TabIndex = 2;
            this.FavoritesCountLabel.Text = "0";
            // 
            // FavoritesLabel
            // 
            this.FavoritesLabel.AutoSize = true;
            this.FavoritesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavoritesLabel.Location = new System.Drawing.Point(6, 16);
            this.FavoritesLabel.Name = "FavoritesLabel";
            this.FavoritesLabel.Size = new System.Drawing.Size(63, 13);
            this.FavoritesLabel.TabIndex = 1;
            this.FavoritesLabel.Text = "Favorites:";
            // 
            // FavoritesGroupBox
            // 
            this.FavoritesGroupBox.Controls.Add(this.FavoritesListView);
            this.FavoritesGroupBox.Controls.Add(this.FavoritesLabel);
            this.FavoritesGroupBox.Controls.Add(this.FavoritesCountLabel);
            this.FavoritesGroupBox.Location = new System.Drawing.Point(218, 202);
            this.FavoritesGroupBox.Name = "FavoritesGroupBox";
            this.FavoritesGroupBox.Size = new System.Drawing.Size(260, 289);
            this.FavoritesGroupBox.TabIndex = 4;
            this.FavoritesGroupBox.TabStop = false;
            this.FavoritesGroupBox.Text = "Favorites";
            // 
            // FavoritesListView
            // 
            this.FavoritesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FavoritesNameColumnHeader,
            this.FavoritesIDColumnHeader});
            this.FavoritesListView.FullRowSelect = true;
            this.FavoritesListView.GridLines = true;
            this.FavoritesListView.HideSelection = false;
            this.FavoritesListView.Location = new System.Drawing.Point(6, 32);
            this.FavoritesListView.MultiSelect = false;
            this.FavoritesListView.Name = "FavoritesListView";
            this.FavoritesListView.Size = new System.Drawing.Size(246, 251);
            this.FavoritesListView.TabIndex = 0;
            this.FavoritesListView.UseCompatibleStateImageBehavior = false;
            this.FavoritesListView.View = System.Windows.Forms.View.Details;
            this.FavoritesListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FavoritesListView_MouseUp);
            // 
            // FavoritesNameColumnHeader
            // 
            this.FavoritesNameColumnHeader.Text = "Name";
            this.FavoritesNameColumnHeader.Width = 237;
            // 
            // FavoritesIDColumnHeader
            // 
            this.FavoritesIDColumnHeader.Text = "";
            this.FavoritesIDColumnHeader.Width = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EEStatusGroupBox
            // 
            this.EEStatusGroupBox.Controls.Add(this.FlashCPictureBox);
            this.EEStatusGroupBox.Controls.Add(this.FlashCLabel);
            this.EEStatusGroupBox.Controls.Add(this.UniversePictureBox);
            this.EEStatusGroupBox.Controls.Add(this.UniverseLabel);
            this.EEStatusGroupBox.Controls.Add(this.BetaPictureBox);
            this.EEStatusGroupBox.Controls.Add(this.GameOnPictureBox);
            this.EEStatusGroupBox.Controls.Add(this.GameOnLabel);
            this.EEStatusGroupBox.Controls.Add(this.BetaLabel);
            this.EEStatusGroupBox.Controls.Add(this.GameEPictureBox);
            this.EEStatusGroupBox.Controls.Add(this.GameELabel);
            this.EEStatusGroupBox.Location = new System.Drawing.Point(12, 202);
            this.EEStatusGroupBox.Name = "EEStatusGroupBox";
            this.EEStatusGroupBox.Size = new System.Drawing.Size(200, 283);
            this.EEStatusGroupBox.TabIndex = 6;
            this.EEStatusGroupBox.TabStop = false;
            this.EEStatusGroupBox.Text = "Everybody Edits Status";
            // 
            // FlashCLabel
            // 
            this.FlashCLabel.AutoSize = true;
            this.FlashCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlashCLabel.Location = new System.Drawing.Point(16, 90);
            this.FlashCLabel.Name = "FlashCLabel";
            this.FlashCLabel.Size = new System.Drawing.Size(84, 13);
            this.FlashCLabel.TabIndex = 9;
            this.FlashCLabel.Text = "Flash Cookie:";
            // 
            // GameOnLabel
            // 
            this.GameOnLabel.AutoSize = true;
            this.GameOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOnLabel.Location = new System.Drawing.Point(16, 57);
            this.GameOnLabel.Name = "GameOnLabel";
            this.GameOnLabel.Size = new System.Drawing.Size(83, 13);
            this.GameOnLabel.TabIndex = 2;
            this.GameOnLabel.Text = "Game Online:";
            // 
            // GameELabel
            // 
            this.GameELabel.AutoSize = true;
            this.GameELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameELabel.Location = new System.Drawing.Point(16, 31);
            this.GameELabel.Name = "GameELabel";
            this.GameELabel.Size = new System.Drawing.Size(74, 13);
            this.GameELabel.TabIndex = 0;
            this.GameELabel.Text = "Game Exist:";
            // 
            // FlashCPictureBox
            // 
            this.FlashCPictureBox.Image = global::EEFixer.Properties.Resources.cross;
            this.FlashCPictureBox.Location = new System.Drawing.Point(137, 90);
            this.FlashCPictureBox.Name = "FlashCPictureBox";
            this.FlashCPictureBox.Size = new System.Drawing.Size(16, 16);
            this.FlashCPictureBox.TabIndex = 10;
            this.FlashCPictureBox.TabStop = false;
            // 
            // UniversePictureBox
            // 
            this.UniversePictureBox.Image = global::EEFixer.Properties.Resources.cross;
            this.UniversePictureBox.Location = new System.Drawing.Point(137, 154);
            this.UniversePictureBox.Name = "UniversePictureBox";
            this.UniversePictureBox.Size = new System.Drawing.Size(16, 16);
            this.UniversePictureBox.TabIndex = 8;
            this.UniversePictureBox.TabStop = false;
            // 
            // BetaPictureBox
            // 
            this.BetaPictureBox.Image = global::EEFixer.Properties.Resources.cross;
            this.BetaPictureBox.Location = new System.Drawing.Point(137, 127);
            this.BetaPictureBox.Name = "BetaPictureBox";
            this.BetaPictureBox.Size = new System.Drawing.Size(16, 16);
            this.BetaPictureBox.TabIndex = 6;
            this.BetaPictureBox.TabStop = false;
            // 
            // GameOnPictureBox
            // 
            this.GameOnPictureBox.Image = global::EEFixer.Properties.Resources.cross;
            this.GameOnPictureBox.Location = new System.Drawing.Point(137, 57);
            this.GameOnPictureBox.Name = "GameOnPictureBox";
            this.GameOnPictureBox.Size = new System.Drawing.Size(16, 16);
            this.GameOnPictureBox.TabIndex = 3;
            this.GameOnPictureBox.TabStop = false;
            // 
            // GameEPictureBox
            // 
            this.GameEPictureBox.Image = global::EEFixer.Properties.Resources.cross;
            this.GameEPictureBox.Location = new System.Drawing.Point(137, 31);
            this.GameEPictureBox.Name = "GameEPictureBox";
            this.GameEPictureBox.Size = new System.Drawing.Size(16, 16);
            this.GameEPictureBox.TabIndex = 1;
            this.GameEPictureBox.TabStop = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::EEFixer.Properties.Resources.information;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FavBackupGroupBox
            // 
            this.FavBackupGroupBox.Controls.Add(this.FavBackupListView);
            this.FavBackupGroupBox.Location = new System.Drawing.Point(484, 202);
            this.FavBackupGroupBox.Name = "FavBackupGroupBox";
            this.FavBackupGroupBox.Size = new System.Drawing.Size(260, 289);
            this.FavBackupGroupBox.TabIndex = 7;
            this.FavBackupGroupBox.TabStop = false;
            this.FavBackupGroupBox.Text = "Favorites Backup";
            // 
            // FavBackupListView
            // 
            this.FavBackupListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.FavBackupListView.FullRowSelect = true;
            this.FavBackupListView.GridLines = true;
            this.FavBackupListView.HideSelection = false;
            this.FavBackupListView.Location = new System.Drawing.Point(6, 32);
            this.FavBackupListView.MultiSelect = false;
            this.FavBackupListView.Name = "FavBackupListView";
            this.FavBackupListView.Size = new System.Drawing.Size(246, 251);
            this.FavBackupListView.TabIndex = 0;
            this.FavBackupListView.UseCompatibleStateImageBehavior = false;
            this.FavBackupListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 237;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 0;
            // 
            // FavBackupCheckBox
            // 
            this.FavBackupCheckBox.AutoSize = true;
            this.FavBackupCheckBox.Location = new System.Drawing.Point(6, 60);
            this.FavBackupCheckBox.Name = "FavBackupCheckBox";
            this.FavBackupCheckBox.Size = new System.Drawing.Size(104, 17);
            this.FavBackupCheckBox.TabIndex = 7;
            this.FavBackupCheckBox.Text = "Favorite Backup";
            this.FavBackupCheckBox.UseVisualStyleBackColor = true;
            this.FavBackupCheckBox.CheckedChanged += new System.EventHandler(this.FavBackupCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 498);
            this.Controls.Add(this.FavBackupGroupBox);
            this.Controls.Add(this.EEStatusGroupBox);
            this.Controls.Add(this.FavoritesGroupBox);
            this.Controls.Add(this.ToolGroupBox);
            this.Controls.Add(this.LogGroupBox);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Everybody Edits - Maintenance Tool v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.LogGroupBox.ResumeLayout(false);
            this.ToolGroupBox.ResumeLayout(false);
            this.ToolGroupBox.PerformLayout();
            this.FavoritesGroupBox.ResumeLayout(false);
            this.FavoritesGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.EEStatusGroupBox.ResumeLayout(false);
            this.EEStatusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlashCPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniversePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOnPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameEPictureBox)).EndInit();
            this.FavBackupGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.RichTextBox LogRichTextBox;
        private System.Windows.Forms.GroupBox LogGroupBox;
        private System.Windows.Forms.GroupBox ToolGroupBox;
        private System.Windows.Forms.Label FavoritesCountLabel;
        private System.Windows.Forms.Label FavoritesLabel;
        private System.Windows.Forms.Button EEUJoinButton;
        private System.Windows.Forms.Label BetaLabel;
        private System.Windows.Forms.GroupBox FavoritesGroupBox;
        private System.Windows.Forms.ListView FavoritesListView;
        private System.Windows.Forms.ColumnHeader FavoritesNameColumnHeader;
        private System.Windows.Forms.ColumnHeader FavoritesIDColumnHeader;
        private System.Windows.Forms.PictureBox BetaPictureBox;
        private System.Windows.Forms.PictureBox UniversePictureBox;
        private System.Windows.Forms.Label UniverseLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox EEStatusGroupBox;
        private System.Windows.Forms.PictureBox GameOnPictureBox;
        private System.Windows.Forms.Label GameOnLabel;
        private System.Windows.Forms.PictureBox GameEPictureBox;
        private System.Windows.Forms.Label GameELabel;
        private System.Windows.Forms.Button DelFButton;
        private System.Windows.Forms.PictureBox FlashCPictureBox;
        private System.Windows.Forms.Label FlashCLabel;
        private System.Windows.Forms.GroupBox FavBackupGroupBox;
        private System.Windows.Forms.ListView FavBackupListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox FavBackupCheckBox;
    }
}

