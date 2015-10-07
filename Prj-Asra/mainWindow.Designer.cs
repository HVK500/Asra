namespace Prj_Asra
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.cmBox = new System.Windows.Forms.ComboBox();
            this.btnCmDel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chbComplete = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLibrary = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnLboxClear = new System.Windows.Forms.Button();
            this.picBoxTitle = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.numEpisode = new System.Windows.Forms.NumericUpDown();
            this.numSeason = new System.Windows.Forms.NumericUpDown();
            this.btnBrowseTo = new System.Windows.Forms.Button();
            this.browserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEpisode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeason)).BeginInit();
            this.SuspendLayout();
            // 
            // cmBox
            // 
            this.cmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBox.FormattingEnabled = true;
            this.cmBox.Location = new System.Drawing.Point(404, 63);
            this.cmBox.Name = "cmBox";
            this.cmBox.Size = new System.Drawing.Size(230, 21);
            this.cmBox.TabIndex = 0;
            this.cmBox.TabStop = false;
            this.cmBox.SelectedIndexChanged += new System.EventHandler(this.cmBox_SelectedIndexChanged);
            // 
            // btnCmDel
            // 
            this.btnCmDel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCmDel.Location = new System.Drawing.Point(640, 63);
            this.btnCmDel.Name = "btnCmDel";
            this.btnCmDel.Size = new System.Drawing.Size(22, 21);
            this.btnCmDel.TabIndex = 1;
            this.btnCmDel.TabStop = false;
            this.btnCmDel.Text = "X";
            this.btnCmDel.UseVisualStyleBackColor = true;
            this.btnCmDel.Click += new System.EventHandler(this.btnCmDel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TabStop = false;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // chbComplete
            // 
            this.chbComplete.AutoSize = true;
            this.chbComplete.Enabled = false;
            this.chbComplete.Location = new System.Drawing.Point(367, 95);
            this.chbComplete.Name = "chbComplete";
            this.chbComplete.Size = new System.Drawing.Size(70, 17);
            this.chbComplete.TabIndex = 3;
            this.chbComplete.TabStop = false;
            this.chbComplete.Text = "Complete";
            this.chbComplete.UseVisualStyleBackColor = true;
            this.chbComplete.CheckedChanged += new System.EventHandler(this.chbComplete_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(237, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 46);
            this.btnClear.TabIndex = 4;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(12, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(12, 352);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.Location = new System.Drawing.Point(12, 209);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(321, 134);
            this.lBox.TabIndex = 5;
            this.lBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Anime / Series Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Next episode number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Season number :";
            // 
            // lblLibrary
            // 
            this.lblLibrary.AutoSize = true;
            this.lblLibrary.Location = new System.Drawing.Point(497, 44);
            this.lblLibrary.Name = "lblLibrary";
            this.lblLibrary.Size = new System.Drawing.Size(44, 13);
            this.lblLibrary.TabIndex = 6;
            this.lblLibrary.Text = "Library :";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Enabled = false;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(238, 51);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(20, 9);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "v*.**";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLboxClear
            // 
            this.btnLboxClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLboxClear.Location = new System.Drawing.Point(339, 209);
            this.btnLboxClear.Name = "btnLboxClear";
            this.btnLboxClear.Size = new System.Drawing.Size(22, 21);
            this.btnLboxClear.TabIndex = 1;
            this.btnLboxClear.TabStop = false;
            this.btnLboxClear.Text = "X";
            this.btnLboxClear.UseVisualStyleBackColor = true;
            this.btnLboxClear.Click += new System.EventHandler(this.btnLboxClear_Click);
            // 
            // picBoxTitle
            // 
            this.picBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.picBoxTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxTitle.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTitle.Image")));
            this.picBoxTitle.Location = new System.Drawing.Point(50, 12);
            this.picBoxTitle.Name = "picBoxTitle";
            this.picBoxTitle.Size = new System.Drawing.Size(249, 72);
            this.picBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTitle.TabIndex = 7;
            this.picBoxTitle.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBox.Image = global::Prj_Asra.Properties.Resources.asLayout;
            this.picBox.Location = new System.Drawing.Point(345, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(380, 385);
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            // 
            // numEpisode
            // 
            this.numEpisode.Enabled = false;
            this.numEpisode.Location = new System.Drawing.Point(131, 119);
            this.numEpisode.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEpisode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEpisode.Name = "numEpisode";
            this.numEpisode.Size = new System.Drawing.Size(100, 20);
            this.numEpisode.TabIndex = 8;
            this.numEpisode.TabStop = false;
            this.numEpisode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEpisode.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numEpisode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSeason
            // 
            this.numSeason.Enabled = false;
            this.numSeason.Location = new System.Drawing.Point(131, 145);
            this.numSeason.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeason.Name = "numSeason";
            this.numSeason.Size = new System.Drawing.Size(100, 20);
            this.numSeason.TabIndex = 8;
            this.numSeason.TabStop = false;
            this.numSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSeason.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numSeason.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBrowseTo
            // 
            this.btnBrowseTo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBrowseTo.Enabled = false;
            this.btnBrowseTo.Location = new System.Drawing.Point(237, 171);
            this.btnBrowseTo.Name = "btnBrowseTo";
            this.btnBrowseTo.Size = new System.Drawing.Size(124, 23);
            this.btnBrowseTo.TabIndex = 0;
            this.btnBrowseTo.TabStop = false;
            this.btnBrowseTo.Text = "Browse to...";
            this.btnBrowseTo.UseVisualStyleBackColor = true;
            this.btnBrowseTo.Click += new System.EventHandler(this.btnBrowseTo_Click);
            // 
            // browserDialog
            // 
            this.browserDialog.Description = "Select the folder containing  files";
            this.browserDialog.ShowNewFolderButton = false;
            // 
            // mainWindow
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(724, 387);
            this.Controls.Add(this.numSeason);
            this.Controls.Add(this.numEpisode);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.picBoxTitle);
            this.Controls.Add(this.lblLibrary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBrowseTo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chbComplete);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnLboxClear);
            this.Controls.Add(this.btnCmDel);
            this.Controls.Add(this.cmBox);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASRA - v*.**";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEpisode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBox;
        private System.Windows.Forms.Button btnCmDel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chbComplete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLibrary;
        private System.Windows.Forms.PictureBox picBoxTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnLboxClear;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.NumericUpDown numEpisode;
        private System.Windows.Forms.NumericUpDown numSeason;
        private System.Windows.Forms.Button btnBrowseTo;
        private System.Windows.Forms.FolderBrowserDialog browserDialog;
    }
}

