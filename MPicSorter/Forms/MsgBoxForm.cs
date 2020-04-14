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
    public partial class MsgBoxForm : Form
    {        
        public bool RemindMyChoice { get; private set; } = false;

        public string TextMessage { get; private set; }
        public string Caption { get; private set; }
        public MessageBoxButtons Buttons { get; private set; }
        public MessageBoxIcon IconMessage { get; private set; }
        public MessageBoxDefaultButton DefaultButton { get; private set; }
        public bool ActivateRemindCheck { get; private set; }

        private bool internalClose = false;

        public MsgBoxForm(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1, bool activateRemindCheck = false)
        {
            InitializeComponent();
            TextMessage = text;
            Caption = caption;
            Buttons = buttons;
            IconMessage = icon;
            DefaultButton = defaultButton;
            ActivateRemindCheck = activateRemindCheck;

            textLbl.Text = TextMessage;
            this.Text = Caption;
            remindChk.Text = LangManager.GetString("remindMyChoiceForAllFiles");

            switch (Buttons)
            {
                case MessageBoxButtons.OK:
                    firstBtn.Hide();
                    secondBtn.Text = "OK";
                    break;
                case MessageBoxButtons.YesNo:
                    firstBtn.Text = LangManager.GetString("yes");
                    secondBtn.Text = LangManager.GetString("no");
                    break;
                default:
                    throw new Exception("Message Box type not available.");
            }

            switch (IconMessage)
            {
                case MessageBoxIcon.Error:
                    iconPct.Image = Properties.Resources.error48;
                    break;
                case MessageBoxIcon.Exclamation:
                    iconPct.Image = Properties.Resources.warning48;
                    break;
                case MessageBoxIcon.Information:
                    iconPct.Image = Properties.Resources.info48;
                    break;
                default:
                    throw new Exception("Message Box icon not available.");
            }

            switch (DefaultButton)
            {
                case MessageBoxDefaultButton.Button1:
                    if (buttons == MessageBoxButtons.YesNo)
                    {
                        this.AcceptButton = firstBtn;
                        firstBtn.Select();
                    }
                    else
                    {
                        this.AcceptButton = secondBtn;
                        secondBtn.Select();
                    }
                    break;
                case MessageBoxDefaultButton.Button2:
                    this.AcceptButton = secondBtn;
                    secondBtn.Select();
                    break;
                default:
                    throw new Exception("Message Box default button not available.");
            }

            if (!ActivateRemindCheck)
            {
                remindChk.Hide();
            }
        }

        private void ValidateDialog(object sender, EventArgs e)
        {
            RemindMyChoice = remindChk.Checked;

            if (Buttons == MessageBoxButtons.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (Buttons == MessageBoxButtons.YesNo)
            {
                if (sender == firstBtn)
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else if (sender == secondBtn)
                {
                    this.DialogResult = DialogResult.No;
                }
            }

            internalClose = true;
            this.Close();
        }

        private void MsgBoxForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (!internalClose);
        }

        private void MsgBoxForm_Shown(object sender, EventArgs e)
        {
            switch (IconMessage)
            {
                case MessageBoxIcon.Error:
                    System.Media.SystemSounds.Hand.Play();
                    break;
                case MessageBoxIcon.Exclamation:
                    System.Media.SystemSounds.Exclamation.Play();
                    break;
                case MessageBoxIcon.Information:
                    System.Media.SystemSounds.Asterisk.Play();
                    break;
            }
        }
    }
}
