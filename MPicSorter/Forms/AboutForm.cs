using System;
using System.Windows.Forms;

namespace MPicSorter.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            versionLbl.Text = "Version: " + Application.ProductVersion.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}