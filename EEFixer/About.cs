using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEFixer
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void IconsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to continue to fatcowhosting icons?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
            {
                Process.Start("https://www.fatcow.com/free-icons");
            }
        }

        private void About_Load(object sender, EventArgs e)
        {
            AboutTextBox.HideSelection = true;
        }
    }
}
