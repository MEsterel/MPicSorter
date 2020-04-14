namespace MPicSorter.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Your pictures");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2017-01-26", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("2017-01", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("2017", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.formatContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formatNumeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.inputSelectionLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseInputBtn = new System.Windows.Forms.Button();
            this.inputFolderLbl = new System.Windows.Forms.Label();
            this.inputPathLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.outputSelectionLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.outputPathLbl = new System.Windows.Forms.Label();
            this.outputDirectoryLbl = new System.Windows.Forms.Label();
            this.browseOutputBtn = new System.Windows.Forms.Button();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.exampleLbl = new System.Windows.Forms.Label();
            this.textFormatChk = new System.Windows.Forms.CheckBox();
            this.numeralFormatChk = new System.Windows.Forms.CheckBox();
            this.dateFormatLbl = new System.Windows.Forms.Label();
            this.formatExampleTree = new System.Windows.Forms.TreeView();
            this.fileIconImageList = new System.Windows.Forms.ImageList(this.components);
            this.dayChk = new System.Windows.Forms.CheckBox();
            this.monthChk = new System.Windows.Forms.CheckBox();
            this.yearChk = new System.Windows.Forms.CheckBox();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.formatContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.outputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sortGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // formatContextMenu
            // 
            this.formatContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatNumeralToolStripMenuItem,
            this.formatTextToolStripMenuItem});
            this.formatContextMenu.Name = "formatContextMenu";
            this.formatContextMenu.Size = new System.Drawing.Size(163, 48);
            // 
            // formatNumeralToolStripMenuItem
            // 
            this.formatNumeralToolStripMenuItem.Name = "formatNumeralToolStripMenuItem";
            this.formatNumeralToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.formatNumeralToolStripMenuItem.Text = "Format: numeral";
            this.formatNumeralToolStripMenuItem.Click += new System.EventHandler(this.FormatNumeralToolStripMenuItem_Click);
            // 
            // formatTextToolStripMenuItem
            // 
            this.formatTextToolStripMenuItem.Name = "formatTextToolStripMenuItem";
            this.formatTextToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.formatTextToolStripMenuItem.Text = "Format: text";
            this.formatTextToolStripMenuItem.Click += new System.EventHandler(this.FormatTextToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.inputPanel);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // inputPanel
            // 
            this.inputPanel.AllowDrop = true;
            this.inputPanel.Controls.Add(this.inputSelectionLbl);
            this.inputPanel.Controls.Add(this.pictureBox1);
            this.inputPanel.Controls.Add(this.browseInputBtn);
            this.inputPanel.Controls.Add(this.inputFolderLbl);
            this.inputPanel.Controls.Add(this.inputPathLbl);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(3, 21);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(269, 170);
            this.inputPanel.TabIndex = 8;
            this.inputPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputPanel_DragEnter);
            // 
            // inputSelectionLbl
            // 
            this.inputSelectionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSelectionLbl.Location = new System.Drawing.Point(0, 78);
            this.inputSelectionLbl.Name = "inputSelectionLbl";
            this.inputSelectionLbl.Size = new System.Drawing.Size(269, 17);
            this.inputSelectionLbl.TabIndex = 5;
            this.inputSelectionLbl.Text = "Please select a folder to sort";
            this.inputSelectionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::MPicSorter.Properties.Resources.input48;
            this.pictureBox1.Location = new System.Drawing.Point(109, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // browseInputBtn
            // 
            this.browseInputBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.browseInputBtn.Location = new System.Drawing.Point(83, 98);
            this.browseInputBtn.Name = "browseInputBtn";
            this.browseInputBtn.Size = new System.Drawing.Size(100, 27);
            this.browseInputBtn.TabIndex = 4;
            this.browseInputBtn.Text = "Browse...";
            this.browseInputBtn.UseVisualStyleBackColor = true;
            this.browseInputBtn.Click += new System.EventHandler(this.BrowseInputBtn_Click);
            // 
            // inputFolderLbl
            // 
            this.inputFolderLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFolderLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFolderLbl.Location = new System.Drawing.Point(0, 54);
            this.inputFolderLbl.Name = "inputFolderLbl";
            this.inputFolderLbl.Size = new System.Drawing.Size(269, 17);
            this.inputFolderLbl.TabIndex = 1;
            this.inputFolderLbl.Text = "INPUT FOLDER";
            this.inputFolderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputPathLbl
            // 
            this.inputPathLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPathLbl.AutoEllipsis = true;
            this.inputPathLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPathLbl.Location = new System.Drawing.Point(3, 135);
            this.inputPathLbl.Name = "inputPathLbl";
            this.inputPathLbl.Size = new System.Drawing.Size(266, 34);
            this.inputPathLbl.TabIndex = 4;
            this.inputPathLbl.Text = "Input: N/A";
            this.inputPathLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 200);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.outputPanel);
            this.groupBox2.Location = new System.Drawing.Point(284, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 194);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // outputPanel
            // 
            this.outputPanel.AllowDrop = true;
            this.outputPanel.Controls.Add(this.outputSelectionLbl);
            this.outputPanel.Controls.Add(this.pictureBox2);
            this.outputPanel.Controls.Add(this.outputPathLbl);
            this.outputPanel.Controls.Add(this.outputDirectoryLbl);
            this.outputPanel.Controls.Add(this.browseOutputBtn);
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel.Location = new System.Drawing.Point(3, 21);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(269, 170);
            this.outputPanel.TabIndex = 8;
            this.outputPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.OutputPanel_DragEnter);
            // 
            // outputSelectionLbl
            // 
            this.outputSelectionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputSelectionLbl.Location = new System.Drawing.Point(0, 78);
            this.outputSelectionLbl.Name = "outputSelectionLbl";
            this.outputSelectionLbl.Size = new System.Drawing.Size(269, 17);
            this.outputSelectionLbl.TabIndex = 6;
            this.outputSelectionLbl.Text = "Please select a destination directory";
            this.outputSelectionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::MPicSorter.Properties.Resources.output48;
            this.pictureBox2.Location = new System.Drawing.Point(110, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // outputPathLbl
            // 
            this.outputPathLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPathLbl.AutoEllipsis = true;
            this.outputPathLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPathLbl.Location = new System.Drawing.Point(0, 135);
            this.outputPathLbl.Name = "outputPathLbl";
            this.outputPathLbl.Size = new System.Drawing.Size(269, 32);
            this.outputPathLbl.TabIndex = 3;
            this.outputPathLbl.Text = "Output: N/A";
            this.outputPathLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDirectoryLbl
            // 
            this.outputDirectoryLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirectoryLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDirectoryLbl.Location = new System.Drawing.Point(0, 54);
            this.outputDirectoryLbl.Name = "outputDirectoryLbl";
            this.outputDirectoryLbl.Size = new System.Drawing.Size(269, 17);
            this.outputDirectoryLbl.TabIndex = 1;
            this.outputDirectoryLbl.Text = "OUTPUT DIRECTORY";
            this.outputDirectoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browseOutputBtn
            // 
            this.browseOutputBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.browseOutputBtn.Location = new System.Drawing.Point(84, 98);
            this.browseOutputBtn.Name = "browseOutputBtn";
            this.browseOutputBtn.Size = new System.Drawing.Size(100, 27);
            this.browseOutputBtn.TabIndex = 2;
            this.browseOutputBtn.Text = "Browse...";
            this.browseOutputBtn.UseVisualStyleBackColor = true;
            this.browseOutputBtn.Click += new System.EventHandler(this.BrowseOutputBtn_Click);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortGroupBox.Controls.Add(this.exampleLbl);
            this.sortGroupBox.Controls.Add(this.textFormatChk);
            this.sortGroupBox.Controls.Add(this.numeralFormatChk);
            this.sortGroupBox.Controls.Add(this.dateFormatLbl);
            this.sortGroupBox.Controls.Add(this.formatExampleTree);
            this.sortGroupBox.Controls.Add(this.dayChk);
            this.sortGroupBox.Controls.Add(this.monthChk);
            this.sortGroupBox.Controls.Add(this.yearChk);
            this.sortGroupBox.Location = new System.Drawing.Point(15, 218);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(326, 195);
            this.sortGroupBox.TabIndex = 5;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort pattern";
            // 
            // exampleLbl
            // 
            this.exampleLbl.AutoSize = true;
            this.exampleLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleLbl.Location = new System.Drawing.Point(134, 44);
            this.exampleLbl.Name = "exampleLbl";
            this.exampleLbl.Size = new System.Drawing.Size(54, 15);
            this.exampleLbl.TabIndex = 10;
            this.exampleLbl.Text = "Example:";
            // 
            // textFormatChk
            // 
            this.textFormatChk.AutoSize = true;
            this.textFormatChk.Location = new System.Drawing.Point(28, 159);
            this.textFormatChk.Name = "textFormatChk";
            this.textFormatChk.Size = new System.Drawing.Size(50, 21);
            this.textFormatChk.TabIndex = 9;
            this.textFormatChk.Text = "Text";
            this.textFormatChk.UseVisualStyleBackColor = true;
            this.textFormatChk.CheckedChanged += new System.EventHandler(this.TextFormatChk_CheckedChanged);
            // 
            // numeralFormatChk
            // 
            this.numeralFormatChk.AutoSize = true;
            this.numeralFormatChk.Checked = true;
            this.numeralFormatChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numeralFormatChk.Location = new System.Drawing.Point(28, 132);
            this.numeralFormatChk.Name = "numeralFormatChk";
            this.numeralFormatChk.Size = new System.Drawing.Size(77, 21);
            this.numeralFormatChk.TabIndex = 8;
            this.numeralFormatChk.Text = "Numeral";
            this.numeralFormatChk.UseVisualStyleBackColor = true;
            this.numeralFormatChk.CheckedChanged += new System.EventHandler(this.NumeralFormatChk_CheckedChanged);
            // 
            // dateFormatLbl
            // 
            this.dateFormatLbl.AutoSize = true;
            this.dateFormatLbl.Location = new System.Drawing.Point(9, 108);
            this.dateFormatLbl.Name = "dateFormatLbl";
            this.dateFormatLbl.Size = new System.Drawing.Size(81, 17);
            this.dateFormatLbl.TabIndex = 7;
            this.dateFormatLbl.Text = "Date format:";
            // 
            // formatExampleTree
            // 
            this.formatExampleTree.ImageIndex = 0;
            this.formatExampleTree.ImageList = this.fileIconImageList;
            this.formatExampleTree.Location = new System.Drawing.Point(137, 60);
            this.formatExampleTree.Name = "formatExampleTree";
            treeNode1.ImageKey = "picture16";
            treeNode1.Name = "pictureNode";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Your pictures";
            treeNode2.ContextMenuStrip = this.formatContextMenu;
            treeNode2.ImageKey = "folder16";
            treeNode2.Name = "dayNode";
            treeNode2.Text = "2017-01-26";
            treeNode3.ContextMenuStrip = this.formatContextMenu;
            treeNode3.ImageKey = "folder16";
            treeNode3.Name = "monthNode";
            treeNode3.Text = "2017-01";
            treeNode4.ImageKey = "folder16";
            treeNode4.Name = "yearNode";
            treeNode4.Text = "2017";
            this.formatExampleTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.formatExampleTree.Scrollable = false;
            this.formatExampleTree.SelectedImageIndex = 0;
            this.formatExampleTree.ShowNodeToolTips = true;
            this.formatExampleTree.ShowPlusMinus = false;
            this.formatExampleTree.ShowRootLines = false;
            this.formatExampleTree.Size = new System.Drawing.Size(176, 93);
            this.formatExampleTree.TabIndex = 3;
            this.formatExampleTree.TabStop = false;
            this.formatExampleTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormatExampleTree_MouseUp);
            // 
            // fileIconImageList
            // 
            this.fileIconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileIconImageList.ImageStream")));
            this.fileIconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileIconImageList.Images.SetKeyName(0, "folder16");
            this.fileIconImageList.Images.SetKeyName(1, "picture16");
            // 
            // dayChk
            // 
            this.dayChk.AutoSize = true;
            this.dayChk.Location = new System.Drawing.Point(48, 78);
            this.dayChk.Name = "dayChk";
            this.dayChk.Size = new System.Drawing.Size(49, 21);
            this.dayChk.TabIndex = 2;
            this.dayChk.Text = "Day";
            this.dayChk.UseVisualStyleBackColor = true;
            this.dayChk.CheckedChanged += new System.EventHandler(this.DayChk_CheckedChanged);
            // 
            // monthChk
            // 
            this.monthChk.AutoSize = true;
            this.monthChk.Checked = true;
            this.monthChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.monthChk.Location = new System.Drawing.Point(28, 51);
            this.monthChk.Name = "monthChk";
            this.monthChk.Size = new System.Drawing.Size(65, 21);
            this.monthChk.TabIndex = 1;
            this.monthChk.Text = "Month";
            this.monthChk.UseVisualStyleBackColor = true;
            this.monthChk.CheckedChanged += new System.EventHandler(this.MonthChk_CheckedChanged);
            // 
            // yearChk
            // 
            this.yearChk.AutoSize = true;
            this.yearChk.Checked = true;
            this.yearChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yearChk.Location = new System.Drawing.Point(12, 24);
            this.yearChk.Name = "yearChk";
            this.yearChk.Size = new System.Drawing.Size(52, 21);
            this.yearChk.TabIndex = 0;
            this.yearChk.Text = "Year";
            this.yearChk.UseVisualStyleBackColor = true;
            this.yearChk.CheckedChanged += new System.EventHandler(this.YearChk_CheckedChanged);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.aboutBtn.Image = global::MPicSorter.Properties.Resources.help20;
            this.aboutBtn.Location = new System.Drawing.Point(411, 347);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(112, 31);
            this.aboutBtn.TabIndex = 7;
            this.aboutBtn.Text = " About";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Image = global::MPicSorter.Properties.Resources.check24;
            this.startBtn.Location = new System.Drawing.Point(394, 260);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(146, 44);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = " START";
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // optionsBtn
            // 
            this.optionsBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.optionsBtn.Image = global::MPicSorter.Properties.Resources.gear16;
            this.optionsBtn.Location = new System.Drawing.Point(411, 310);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(112, 31);
            this.optionsBtn.TabIndex = 6;
            this.optionsBtn.Text = " Options";
            this.optionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optionsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::MPicSorter.Properties.Resources.arrowRightBlue48;
            this.pictureBox3.Location = new System.Drawing.Point(268, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 427);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MPicSorter";
            this.formatContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.outputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label inputFolderLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label outputDirectoryLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button browseOutputBtn;
        private System.Windows.Forms.Button browseInputBtn;
        private System.Windows.Forms.Label inputPathLbl;
        private System.Windows.Forms.Label outputPathLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.TreeView formatExampleTree;
        private System.Windows.Forms.CheckBox dayChk;
        private System.Windows.Forms.CheckBox monthChk;
        private System.Windows.Forms.CheckBox yearChk;
        private System.Windows.Forms.ImageList fileIconImageList;
        private System.Windows.Forms.Label inputSelectionLbl;
        private System.Windows.Forms.Label outputSelectionLbl;
        private System.Windows.Forms.Label dateFormatLbl;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox textFormatChk;
        private System.Windows.Forms.CheckBox numeralFormatChk;
        private System.Windows.Forms.ContextMenuStrip formatContextMenu;
        private System.Windows.Forms.ToolStripMenuItem formatNumeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatTextToolStripMenuItem;
        private System.Windows.Forms.Label exampleLbl;
    }
}

