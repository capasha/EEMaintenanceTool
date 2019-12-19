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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EEUJoinButton = new System.Windows.Forms.Button();
            this.BetaLabel = new System.Windows.Forms.Label();
            this.FavoritesCountLabel = new System.Windows.Forms.Label();
            this.FavoritesLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FavoritesListView = new System.Windows.Forms.ListView();
            this.FavoritesNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FavoritesIDColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UniverseLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UniversePictureBox = new System.Windows.Forms.PictureBox();
            this.BetaPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniversePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.PasswordLabel);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.EmailLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LogRichTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(218, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UniversePictureBox);
            this.groupBox3.Controls.Add(this.UniverseLabel);
            this.groupBox3.Controls.Add(this.BetaPictureBox);
            this.groupBox3.Controls.Add(this.EEUJoinButton);
            this.groupBox3.Controls.Add(this.BetaLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 106);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EEU Signup";
            // 
            // EEUJoinButton
            // 
            this.EEUJoinButton.Enabled = false;
            this.EEUJoinButton.Location = new System.Drawing.Point(17, 72);
            this.EEUJoinButton.Name = "EEUJoinButton";
            this.EEUJoinButton.Size = new System.Drawing.Size(101, 23);
            this.EEUJoinButton.TabIndex = 5;
            this.EEUJoinButton.Text = "Sign Up to EEU";
            this.EEUJoinButton.UseVisualStyleBackColor = true;
            this.EEUJoinButton.Click += new System.EventHandler(this.EEUJoinButton_Click);
            // 
            // BetaLabel
            // 
            this.BetaLabel.AutoSize = true;
            this.BetaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetaLabel.Location = new System.Drawing.Point(15, 21);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FavoritesListView);
            this.groupBox4.Controls.Add(this.FavoritesLabel);
            this.groupBox4.Controls.Add(this.FavoritesCountLabel);
            this.groupBox4.Location = new System.Drawing.Point(218, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 274);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Favorites";
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
            this.FavoritesListView.Size = new System.Drawing.Size(246, 236);
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
            // UniverseLabel
            // 
            this.UniverseLabel.AutoSize = true;
            this.UniverseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniverseLabel.Location = new System.Drawing.Point(15, 50);
            this.UniverseLabel.Name = "UniverseLabel";
            this.UniverseLabel.Size = new System.Drawing.Size(61, 13);
            this.UniverseLabel.TabIndex = 7;
            this.UniverseLabel.Text = "Universe:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UniversePictureBox
            // 
            this.UniversePictureBox.Image = global::EEFixer.Properties.Resources.cross;
            this.UniversePictureBox.Location = new System.Drawing.Point(82, 50);
            this.UniversePictureBox.Name = "UniversePictureBox";
            this.UniversePictureBox.Size = new System.Drawing.Size(16, 16);
            this.UniversePictureBox.TabIndex = 8;
            this.UniversePictureBox.TabStop = false;
            // 
            // BetaPictureBox
            // 
            this.BetaPictureBox.Image = global::EEFixer.Properties.Resources.cross;
            this.BetaPictureBox.Location = new System.Drawing.Point(58, 21);
            this.BetaPictureBox.Name = "BetaPictureBox";
            this.BetaPictureBox.Size = new System.Drawing.Size(16, 16);
            this.BetaPictureBox.TabIndex = 6;
            this.BetaPictureBox.TabStop = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::EEFixer.Properties.Resources.information;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 480);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Everybody Edits - Maintenance Tool v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniversePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.RichTextBox LogRichTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label FavoritesCountLabel;
        private System.Windows.Forms.Label FavoritesLabel;
        private System.Windows.Forms.Button EEUJoinButton;
        private System.Windows.Forms.Label BetaLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView FavoritesListView;
        private System.Windows.Forms.ColumnHeader FavoritesNameColumnHeader;
        private System.Windows.Forms.ColumnHeader FavoritesIDColumnHeader;
        private System.Windows.Forms.PictureBox BetaPictureBox;
        private System.Windows.Forms.PictureBox UniversePictureBox;
        private System.Windows.Forms.Label UniverseLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

