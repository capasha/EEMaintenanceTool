namespace EEFixer
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.AboutTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IconsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MainIconLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutTextBox
            // 
            this.AboutTextBox.Location = new System.Drawing.Point(12, 12);
            this.AboutTextBox.Multiline = true;
            this.AboutTextBox.Name = "AboutTextBox";
            this.AboutTextBox.ReadOnly = true;
            this.AboutTextBox.Size = new System.Drawing.Size(225, 159);
            this.AboutTextBox.TabIndex = 1;
            this.AboutTextBox.Text = resources.GetString("AboutTextBox.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "This tool is made by Capasha/Doh.";
            // 
            // IconsLinkLabel
            // 
            this.IconsLinkLabel.AutoSize = true;
            this.IconsLinkLabel.Location = new System.Drawing.Point(12, 231);
            this.IconsLinkLabel.Name = "IconsLinkLabel";
            this.IconsLinkLabel.Size = new System.Drawing.Size(151, 13);
            this.IconsLinkLabel.TabIndex = 2;
            this.IconsLinkLabel.TabStop = true;
            this.IconsLinkLabel.Text = "Icons made by Fatcow hosting";
            this.IconsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IconsLinkLabel_LinkClicked);
            // 
            // MainIconLabel
            // 
            this.MainIconLabel.AutoSize = true;
            this.MainIconLabel.Location = new System.Drawing.Point(12, 208);
            this.MainIconLabel.Name = "MainIconLabel";
            this.MainIconLabel.Size = new System.Drawing.Size(138, 13);
            this.MainIconLabel.TabIndex = 3;
            this.MainIconLabel.Text = "Main Icon made by nikko99";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 280);
            this.Controls.Add(this.MainIconLabel);
            this.Controls.Add(this.IconsLinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AboutTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AboutTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel IconsLinkLabel;
        private System.Windows.Forms.Label MainIconLabel;
    }
}