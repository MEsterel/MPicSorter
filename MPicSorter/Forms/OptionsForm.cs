using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPicSorter.Lang;

namespace MPicSorter.Forms
{
    public partial class OptionsForm : Form
    {
        public bool ChangedLanguage { get; private set; } = false;

        public OptionsForm()
        {
            InitializeComponent();

            optionsLbl.Text = LangManager.GetString("optionsLbl");
            languageLbl.Text = LangManager.GetString("languageLbl");
            languageCmb.Items.AddRange(LangManager.LangNames.Values.ToArray());

            languageCmb.SelectedItem = LangManager.LangNames[Properties.Settings.Default.language];
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {

            string languageKey = LangManager.LangNames.FirstOrDefault(x => x.Value == languageCmb.SelectedItem.ToString()).Key;
            if (languageKey != Properties.Settings.Default.language)
            {
                ChangedLanguage = true;
                Properties.Settings.Default.language = languageKey;
            }

            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
