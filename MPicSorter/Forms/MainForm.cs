using Microsoft.WindowsAPICodePack.Dialogs;
using MPicSorter.Lang;
using MPicSorter.Objects;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MPicSorter.Forms
{
    public partial class MainForm : Form
    {
        private string inputDirectory = "";
        private string outputDirectory = "";

        public MainForm()
        {
            InitializeComponent();
            UpdateUICulture();

            yearChk.Checked = Properties.Settings.Default.yearChk;
            monthChk.Checked = Properties.Settings.Default.monthChk;
            dayChk.Checked = Properties.Settings.Default.dayChk;

            if (Properties.Settings.Default.monthFormat == DateFormat.Numeral && Properties.Settings.Default.dayFormat == DateFormat.Numeral)
            {
                numeralFormatChk.Checked = true;
            }
            else if (Properties.Settings.Default.monthFormat == DateFormat.Text && Properties.Settings.Default.dayFormat == DateFormat.Text)
            {
                textFormatChk.Checked = true;
            }
            else
            {
                numeralFormatChk.CheckState = CheckState.Indeterminate;
                textFormatChk.CheckState = CheckState.Indeterminate;
            }
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            Point location = this.PointToScreen(Point.Empty);
            af.Location = new Point(location.X + (this.Width / 2) - (af.Width / 2),
                location.Y + (this.Height / 2) - (af.Height / 2) - 30);
            af.ShowDialog();
        }

        private void BrowseInputBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                inputDirectory = dialog.FileName;
                inputPathLbl.Text = LangManager.GetString("inputPathLbl") + " " + inputDirectory;
            }
        }

        private void BrowseOutputBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                outputDirectory = dialog.FileName;
                outputPathLbl.Text = LangManager.GetString("outputPathLbl") + " " + outputDirectory;
            }
        }

        private void DayChk_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dayChk = dayChk.Checked;

            if (!Properties.Settings.Default.yearChk && !Properties.Settings.Default.monthChk && !Properties.Settings.Default.dayChk)
            {
                Properties.Settings.Default.yearChk = true;
                yearChk.Checked = true;
            }

            Properties.Settings.Default.Save();
            RefreshTree();
        }

        private void FormatExampleTree_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Select the clicked node
                formatExampleTree.SelectedNode = formatExampleTree.GetNodeAt(e.X, e.Y);

                if (formatExampleTree.SelectedNode != null)
                {
                    formatContextMenu.Show(formatExampleTree, e.Location);
                }
            }
        }

        private void FormatNumeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = formatExampleTree.SelectedNode;

            if (selectedNode.Tag.ToString() == "monthNode")
            {
                Properties.Settings.Default.monthFormat = DateFormat.Numeral;
            }
            else if (selectedNode.Tag.ToString() == "dayNode")
            {
                Properties.Settings.Default.dayFormat = DateFormat.Numeral;
            }

            if (Properties.Settings.Default.monthFormat == DateFormat.Numeral && Properties.Settings.Default.dayFormat == DateFormat.Numeral)
            {
                numeralFormatChk.CheckState = CheckState.Checked;
                textFormatChk.CheckState = CheckState.Unchecked;
            }
            else
            {
                numeralFormatChk.CheckState = CheckState.Indeterminate;
                textFormatChk.CheckState = CheckState.Indeterminate;
            }

            Properties.Settings.Default.Save();
            RefreshTree();
        }

        private void FormatTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = formatExampleTree.SelectedNode;

            if (selectedNode.Tag.ToString() == "monthNode")
            {
                Properties.Settings.Default.monthFormat = DateFormat.Text;
            }
            else if (selectedNode.Tag.ToString() == "dayNode")
            {
                Properties.Settings.Default.dayFormat = DateFormat.Text;
            }

            if (Properties.Settings.Default.monthFormat == DateFormat.Text && Properties.Settings.Default.dayFormat == DateFormat.Text)
            {
                textFormatChk.CheckState = CheckState.Checked;
                numeralFormatChk.CheckState = CheckState.Unchecked;
            }
            else
            {
                numeralFormatChk.CheckState = CheckState.Indeterminate;
                textFormatChk.CheckState = CheckState.Indeterminate;
            }

            Properties.Settings.Default.Save();
            RefreshTree();
        }

        private void InputPanel_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                    effects = DragDropEffects.Copy;
            }

            e.Effect = effects;
        }

        private void MonthChk_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.monthChk = monthChk.Checked;

            if (!Properties.Settings.Default.yearChk && !Properties.Settings.Default.monthChk && !Properties.Settings.Default.dayChk)
            {
                Properties.Settings.Default.yearChk = true;
                yearChk.Checked = true;
            }

            Properties.Settings.Default.Save();
            RefreshTree();
        }

        private void NumeralFormatChk_CheckedChanged(object sender, EventArgs e)
        {
            if (numeralFormatChk.CheckState == CheckState.Checked)
            {
                textFormatChk.CheckState = CheckState.Unchecked;
            }
            else if (numeralFormatChk.CheckState == CheckState.Unchecked && textFormatChk.CheckState == CheckState.Indeterminate)
            {
                numeralFormatChk.CheckState = CheckState.Checked;
            }
            else if (numeralFormatChk.CheckState == CheckState.Unchecked)
            {
                textFormatChk.CheckState = CheckState.Checked;
            }

            if (numeralFormatChk.CheckState == CheckState.Checked)
            {
                Properties.Settings.Default.monthFormat = DateFormat.Numeral;
                Properties.Settings.Default.dayFormat = DateFormat.Numeral;
                Properties.Settings.Default.Save();
                RefreshTree();
            }
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            OptionsForm of = new OptionsForm();
            Point location = this.PointToScreen(Point.Empty);
            of.Location = new Point(location.X + (this.Width / 2) - (of.Width / 2),
                location.Y + (this.Height / 2) - (of.Height / 2) - 30);
            of.ShowDialog();

            if (of.ChangedLanguage)
            {
                UpdateUICulture();
            }
        }

        private void OutputPanel_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                    effects = DragDropEffects.Copy;
            }

            e.Effect = effects;
        }

        private void RefreshTree()
        {
            formatExampleTree.Nodes.Clear();
            TreeNode lastNode = new TreeNode(LangManager.GetString("yourPicturesLbl"), 1, 1);

            if (Properties.Settings.Default.dayChk)
            {
                TreeNode dayNode;

                if (Properties.Settings.Default.dayFormat == DateFormat.Numeral)
                {
                    dayNode = new TreeNode(DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString("D2") + "-" + DateTime.Now.Day.ToString("D2"), 0, 0);
                }
                else
                {
                    dayNode = new TreeNode(DateTime.Now.Day.ToString() + " " + LangManager.GetMonthFromInt(DateTime.Now.Month) + " " + DateTime.Now.Year.ToString(), 0, 0);
                }

                dayNode.Tag = "dayNode";
                dayNode.Nodes.Add(lastNode);
                lastNode = dayNode;
            }

            if (Properties.Settings.Default.monthChk)
            {
                TreeNode monthNode;

                if (Properties.Settings.Default.monthFormat == DateFormat.Numeral)
                {
                    monthNode = new TreeNode(DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString("D2"), 0, 0);
                }
                else
                {
                    monthNode = new TreeNode(LangManager.ToTitleCase(LangManager.GetMonthFromInt(DateTime.Now.Month)) + " " + DateTime.Now.Year.ToString(), 0, 0);
                }

                monthNode.Tag = "monthNode";
                monthNode.Nodes.Add(lastNode);
                lastNode = monthNode;
            }

            if (Properties.Settings.Default.yearChk)
            {
                TreeNode yearNode = new TreeNode(DateTime.Now.Year.ToString(), 0, 0);
                yearNode.Nodes.Add(lastNode);
                lastNode = yearNode;
            }

            formatExampleTree.Nodes.Add(lastNode);
            formatExampleTree.ExpandAll();
        }

        private void TextFormatChk_CheckedChanged(object sender, EventArgs e)
        {
            if (textFormatChk.CheckState == CheckState.Checked)
            {
                numeralFormatChk.CheckState = CheckState.Unchecked;
            }
            else if (textFormatChk.CheckState == CheckState.Unchecked && numeralFormatChk.CheckState == CheckState.Indeterminate)
            {
                textFormatChk.CheckState = CheckState.Checked;
            }
            else if (textFormatChk.CheckState == CheckState.Unchecked)
            {
                numeralFormatChk.CheckState = CheckState.Checked;
            }

            if (textFormatChk.CheckState == CheckState.Checked)
            {
                Properties.Settings.Default.monthFormat = DateFormat.Text;
                Properties.Settings.Default.dayFormat = DateFormat.Text;
                Properties.Settings.Default.Save();
                RefreshTree();
            }
        }

        private void UpdateUICulture()
        {
            inputFolderLbl.Text = LangManager.GetString("inputFolderLbl");
            inputSelectionLbl.Text = LangManager.GetString("inputSelectionLbl");
            browseInputBtn.Text = LangManager.GetString("browseBtn");
            if (inputDirectory != "")
                inputPathLbl.Text = LangManager.GetString("inputPathLbl") + " " + inputDirectory;
            else
                inputPathLbl.Text = "";
            outputDirectoryLbl.Text = LangManager.GetString("outputDirectoryLbl");
            outputSelectionLbl.Text = LangManager.GetString("outputSelectionLbl");
            browseOutputBtn.Text = LangManager.GetString("browseBtn");
            if (outputDirectory != "")
                outputPathLbl.Text = LangManager.GetString("outputPathLbl") + " " + outputDirectory;
            else
                outputPathLbl.Text = "";
            sortGroupBox.Text = LangManager.GetString("sortGroupBox");
            yearChk.Text = LangManager.GetString("yearChk");
            monthChk.Text = LangManager.GetString("monthChk");
            dayChk.Text = LangManager.GetString("dayChk");
            dateFormatLbl.Text = LangManager.GetString("dateFormatLbl");
            numeralFormatChk.Text = LangManager.GetString("numeralFormatChk");
            textFormatChk.Text = LangManager.GetString("textFormatChk");
            startBtn.Text = LangManager.GetString("startBtn");
            optionsBtn.Text = LangManager.GetString("optionsBtn");
            aboutBtn.Text = LangManager.GetString("aboutBtn");
            exampleLbl.Text = LangManager.GetString("exampleLbl");
            formatNumeralToolStripMenuItem.Text = LangManager.GetString("formatNumeralToolStripMenuItem");
            formatTextToolStripMenuItem.Text = LangManager.GetString("formatTextToolStripMenuItem");

            RefreshTree();
        }

        private void YearChk_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.yearChk = yearChk.Checked;

            if (!Properties.Settings.Default.yearChk && !Properties.Settings.Default.monthChk && !Properties.Settings.Default.dayChk)
            {
                Properties.Settings.Default.yearChk = true;
                yearChk.Checked = true;
            }

            Properties.Settings.Default.Save();
            RefreshTree();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(inputDirectory))
            {
                MsgBoxForm msgbox = new MsgBoxForm(LangManager.GetString("selectInputDirectory"), LangManager.GetString("attention"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                msgbox.ShowDialog();
                return;
            }
            else if (String.IsNullOrWhiteSpace(outputDirectory))
            {
                MsgBoxForm msgbox = new MsgBoxForm(LangManager.GetString("selectOutputDirectory"), LangManager.GetString("attention"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                msgbox.ShowDialog();
                return;
            }

            WorkForm wf = new WorkForm(inputDirectory, outputDirectory);
            Point location = this.PointToScreen(Point.Empty);
            wf.Location = new Point(location.X + (this.Width / 2) - (wf.Width / 2),
                location.Y + (this.Height / 2) - (wf.Height / 2) - 30);

            this.Hide();

            wf.ShowDialog();

            this.Show();
        }
    }
}