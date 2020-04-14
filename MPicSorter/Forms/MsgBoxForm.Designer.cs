namespace MPicSorter.Forms
{
    partial class MsgBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBoxForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.remindChk = new System.Windows.Forms.CheckBox();
            this.firstBtn = new System.Windows.Forms.Button();
            this.secondBtn = new System.Windows.Forms.Button();
            this.textLbl = new System.Windows.Forms.Label();
            this.iconPct = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.remindChk);
            this.panel1.Controls.Add(this.firstBtn);
            this.panel1.Controls.Add(this.secondBtn);
            this.panel1.Location = new System.Drawing.Point(-3, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 52);
            this.panel1.TabIndex = 0;
            // 
            // remindChk
            // 
            this.remindChk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remindChk.Location = new System.Drawing.Point(18, 11);
            this.remindChk.Name = "remindChk";
            this.remindChk.Size = new System.Drawing.Size(192, 30);
            this.remindChk.TabIndex = 2;
            this.remindChk.Text = "Remind my choice for all files";
            this.remindChk.UseVisualStyleBackColor = true;
            // 
            // firstBtn
            // 
            this.firstBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstBtn.Location = new System.Drawing.Point(376, 11);
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Size = new System.Drawing.Size(78, 30);
            this.firstBtn.TabIndex = 0;
            this.firstBtn.Text = "Yes";
            this.firstBtn.UseVisualStyleBackColor = true;
            this.firstBtn.Click += new System.EventHandler(this.ValidateDialog);
            // 
            // secondBtn
            // 
            this.secondBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secondBtn.Location = new System.Drawing.Point(460, 11);
            this.secondBtn.Name = "secondBtn";
            this.secondBtn.Size = new System.Drawing.Size(78, 30);
            this.secondBtn.TabIndex = 1;
            this.secondBtn.Text = "No";
            this.secondBtn.UseVisualStyleBackColor = true;
            this.secondBtn.Click += new System.EventHandler(this.ValidateDialog);
            // 
            // textLbl
            // 
            this.textLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLbl.AutoEllipsis = true;
            this.textLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textLbl.Location = new System.Drawing.Point(75, 11);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(460, 92);
            this.textLbl.TabIndex = 2;
            this.textLbl.Text = resources.GetString("textLbl.Text");
            this.textLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPct
            // 
            this.iconPct.Image = global::MPicSorter.Properties.Resources.warning48;
            this.iconPct.Location = new System.Drawing.Point(14, 33);
            this.iconPct.Name = "iconPct";
            this.iconPct.Size = new System.Drawing.Size(48, 48);
            this.iconPct.TabIndex = 1;
            this.iconPct.TabStop = false;
            // 
            // MsgBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 167);
            this.ControlBox = false;
            this.Controls.Add(this.textLbl);
            this.Controls.Add(this.iconPct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBoxForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attention";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MsgBoxForm_FormClosing);
            this.Shown += new System.EventHandler(this.MsgBoxForm_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox remindChk;
        private System.Windows.Forms.Button firstBtn;
        private System.Windows.Forms.Button secondBtn;
        private System.Windows.Forms.PictureBox iconPct;
        private System.Windows.Forms.Label textLbl;
    }
}