using System.Windows.Forms;
using MPicSorter.Lang;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using MPicSorter.Objects;
using System.Text.RegularExpressions;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace MPicSorter.Forms
{
    public partial class WorkForm : Form
    {
        public string InputDirectory { get; private set; } = "";
        public string OutputDirectory { get; private set; } = "";

        private BackgroundWorker bgWorker = new BackgroundWorker();
        private bool alwaysDelete = false;
        private bool alwaysRename = false;

        public WorkForm(string inputDirectory, string outputDirectory)
        {
            InitializeComponent();
            this.Text = "MPicSorter - " + LangManager.GetString("sortingLbl");
            sortingLbl.Text = LangManager.GetString("sortingLbl");
            cancelBtn.Text = LangManager.GetString("cancelBtn");

            InputDirectory = inputDirectory;
            OutputDirectory = outputDirectory;

            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = true;
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;            
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // 1. Get input paths
            bgWorker.ReportProgress(0, new ProgressChangedArgs(LangManager.GetString("readingExistingFiles")));
            string[] inputFilePaths = Directory.GetFiles(InputDirectory, "*.*", SearchOption.AllDirectories);
            Dictionary<string, string> outputFilePaths = new Dictionary<string, string>();

            int index = 0;
            int fileNumber = inputFilePaths.Length;

            // 2. Create output paths            
            foreach (string path in inputFilePaths)
            {
                bgWorker.ReportProgress(5 + index * 20 / fileNumber, new ProgressChangedArgs(LangManager.GetString("preparingFileSorting"), path));
                if (bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                string fileName = Path.GetFileName(path);
                DateTime fileDate = GetDateTakenFromImage(path);

                if (fileDate != DateTime.MinValue)
                {
                    string yearPart = "";
                    string monthPart = "";
                    string dayPart = "";

                    if (Properties.Settings.Default.yearChk)
                    {
                        yearPart = fileDate.Year.ToString();
                    }

                    if (Properties.Settings.Default.monthChk)
                    {
                        if (Properties.Settings.Default.monthFormat == DateFormat.Numeral)
                        {
                            monthPart = fileDate.Year.ToString() + "-" + fileDate.Month.ToString();
                        }
                        else
                        {
                            monthPart = LangManager.ToTitleCase(LangManager.GetMonthFromInt(fileDate.Month)) + " " + fileDate.Year.ToString();
                        }
                    }

                    if (Properties.Settings.Default.dayChk)
                    {
                        if (Properties.Settings.Default.dayFormat == DateFormat.Numeral)
                        {
                            dayPart = fileDate.Year.ToString() + "-" + fileDate.Month.ToString() + "-" + fileDate.Day.ToString();
                        }
                        else
                        {
                            dayPart = fileDate.Day.ToString() + " " + LangManager.ToTitleCase(LangManager.GetMonthFromInt(fileDate.Month)) + " " + fileDate.Year.ToString();
                        }
                    }

                    outputFilePaths.Add(path, Path.Combine(OutputDirectory, yearPart, monthPart, dayPart, fileName));
                }
                else
                {
                    outputFilePaths.Add(path, Path.Combine(OutputDirectory, "Unknown", fileName));
                }

                index++;
            }
            
            // 3. Copy files to new directory
            index = 0;
            foreach (string path in outputFilePaths.Keys)
            {
                bgWorker.ReportProgress(25 + index * 75 / fileNumber, new ProgressChangedArgs(LangManager.GetString("copyingFiles"), path));
                if (bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                string outputPath = outputFilePaths[path];

                if (File.Exists(outputPath))
                {
                    DialogResult res = DialogResult.None;

                    if (alwaysDelete)
                    {
                        try
                        {
                            File.Delete(outputPath);
                        }
                        catch (Exception ex)
                        {
                            MsgBoxForm msgbox = new MsgBoxForm(LangManager.GetString("file") + " " + path + " " + LangManager.GetString("couldNotBeReplaced") + " " + LangManager.GetString("details") + " " + ex.Message, LangManager.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // now ask the UI thread to update itself
                            this.Invoke((MethodInvoker)delegate {
                                // this code runs on the UI thread!
                                this.Enabled = false;
                                msgbox.ShowDialog();
                                this.Enabled = true;
                            });
                        }
                    }
                    else if (alwaysRename)
                    {
                        int num = 0;
                        while (File.Exists(outputPath))
                        {
                            num++;
                            outputPath = Path.Combine(Path.GetDirectoryName(outputPath), Path.GetFileNameWithoutExtension(outputPath) + " (" + num + ")" + Path.GetExtension(outputPath));
                        }
                    }
                    else
                    {
                        MsgBoxForm msgbox = new MsgBoxForm(LangManager.GetString("aFileNamed") + " " + outputPath + " " + LangManager.GetString("alreadyExistsReplaceIt"), LangManager.GetString("attention"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, true);
                        // now ask the UI thread to update itself
                        this.Invoke((MethodInvoker)delegate {
                            // this code runs on the UI thread!
                            this.Enabled = false;
                            res = msgbox.ShowDialog();
                            this.Enabled = true;
                        });                        

                    
                        if (msgbox.RemindMyChoice)
                        {
                            if (res == DialogResult.Yes)
                            {
                                alwaysDelete = true;
                            }
                            else
                            {
                                alwaysRename = true;
                            }
                            
                        }
                        if (res == DialogResult.Yes)
                        {
                            try
                            {
                                File.Delete(outputPath);
                            }
                            catch (Exception ex)
                            {
                                MsgBoxForm msgbox2 = new MsgBoxForm(LangManager.GetString("file") + " " + path + " " + LangManager.GetString("couldNotBeDeleted") + " " + LangManager.GetString("details") + " " + ex.Message, LangManager.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                // now ask the UI thread to update itself
                                this.Invoke((MethodInvoker)delegate {
                                    // this code runs on the UI thread!
                                    this.Enabled = false;
                                    msgbox.ShowDialog();
                                    this.Enabled = true;
                                });
                            }
                        }
                        else if (res == DialogResult.No)
                        {
                            int num = 0;
                            string outputPathRawName = Path.GetFileNameWithoutExtension(outputPath);
                            while (File.Exists(outputPath))
                            {
                                num++;
                                outputPath = Path.Combine(Path.GetDirectoryName(outputPath), outputPathRawName + " (" + num + ")" + Path.GetExtension(outputPath));
                            }
                        }
                    }
                }

                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(outputPath));
                    File.Copy(path, outputPath, false);
                }
                catch (Exception ex)
                {
                    MsgBoxForm msgbox = new MsgBoxForm(LangManager.GetString("file") + " " + path + " " + LangManager.GetString("couldNotBeCopied") + " " + LangManager.GetString("details") + " " + ex.Message, LangManager.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // now ask the UI thread to update itself
                    this.Invoke((MethodInvoker)delegate {
                        // this code runs on the UI thread!
                        this.Enabled = false;
                        msgbox.ShowDialog();
                        this.Enabled = true;
                    });
                }

                index++;
            }

            // 4. Finalization
            bgWorker.ReportProgress(100, new ProgressChangedArgs(LangManager.GetString("finalizing")));
        }

        private static Regex r = new Regex(":");        
        public static DateTime GetDateTakenFromImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    using (Image myImage = Image.FromStream(fs, false, false))
                    {
                        PropertyItem propItem = myImage.GetPropertyItem(36867);
                        string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                        return DateTime.Parse(dateTaken);
                    }
                }
                catch
                {
                    FileInfo fileInfo = new FileInfo(path);
                    if (fileInfo.LastWriteTime != null)
                    {
                        return fileInfo.LastWriteTime;
                    }
                    else if (fileInfo.CreationTime != null)
                    {
                        return fileInfo.CreationTime;
                    }
                    else
                    {
                        return DateTime.MinValue;
                    }
                }
            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            ProgressChangedArgs args = (ProgressChangedArgs)e.UserState;
            infoLbl.Text = LangManager.GetString("progressionLbl") + " " + e.ProgressPercentage.ToString() + "% - " + args.State;
            
            if (args.ProcessingPath != "")
            {
                infoLbl.Text += Environment.NewLine + LangManager.GetString("processingLbl") + " " + args.ProcessingPath;
            }
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MsgBoxForm msgbox = new MsgBoxForm(LangManager.GetString("workCancelled"), LangManager.GetString("cancel"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                msgbox.ShowDialog();
            }
            else if (e.Error != null)
            {
                MsgBoxForm msgbox = new MsgBoxForm(LangManager.GetString("errorOccured") + " " + LangManager.GetString("details") + " " + e.Error.Message, LangManager.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                msgbox.ShowDialog();
            }
            else
            {
                MsgBoxForm msgbox = new MsgBoxForm(LangManager.GetString("fileSorted"), LangManager.GetString("success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                msgbox.ShowDialog();
            }

            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            MsgBoxForm msgbox = new MsgBoxForm(LangManager.GetString("reallyWantToInterrupt"), LangManager.GetString("attention"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            DialogResult res = msgbox.ShowDialog();
            if (res == DialogResult.Yes)
            {
                bgWorker.CancelAsync();
                cancelBtn.Text = LangManager.GetString("cancellingBtn");
                cancelBtn.Enabled = false;
            }
            
        }

        private void WorkForm_Shown(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void WorkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bgWorker.IsBusy)
            {
                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    MsgBoxForm msgbox1 = new MsgBoxForm(LangManager.GetString("cancellationInProgress"), LangManager.GetString("attention"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    msgbox1.ShowDialog();
                    return;
                }

                MsgBoxForm msgbox = new MsgBoxForm(LangManager.GetString("reallyWantToInterrupt"), LangManager.GetString("attention"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                DialogResult res = msgbox.ShowDialog();
                if (res == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = true;
                    bgWorker.CancelAsync();
                    cancelBtn.Text = LangManager.GetString("cancellingBtn");
                    cancelBtn.Enabled = false;
                }
            }
        }
    }
}