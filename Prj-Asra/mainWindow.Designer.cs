﻿namespace Prj_Asra
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
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
            // 
            // btnCmDel
            // 
            this.btnCmDel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCmDel.Location = new System.Drawing.Point(640, 63);
            this.btnCmDel.Name = "btnCmDel";
            this.btnCmDel.Size = new System.Drawing.Size(22, 21);
            this.btnCmDel.TabIndex = 1;
            this.btnCmDel.Text = "X";
            this.btnCmDel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // chbComplete
            // 
            this.chbComplete.AutoSize = true;
            this.chbComplete.Enabled = false;
            this.chbComplete.Location = new System.Drawing.Point(367, 95);
            this.chbComplete.Name = "chbComplete";
            this.chbComplete.Size = new System.Drawing.Size(70, 17);
            this.chbComplete.TabIndex = 3;
            this.chbComplete.Text = "Complete";
            this.chbComplete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(237, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 46);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(12, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(349, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(12, 352);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
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
            this.lblVersion.Location = new System.Drawing.Point(226, 51);
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
            this.btnLboxClear.Text = "X";
            this.btnLboxClear.UseVisualStyleBackColor = true;
            // 
            // picBoxTitle
            // 
            this.picBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.picBoxTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxTitle.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTitle.Image")));
            this.picBoxTitle.Location = new System.Drawing.Point(38, 12);
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
            // mainWindow
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(724, 387);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.picBoxTitle);
            this.Controls.Add(this.lblLibrary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chbComplete);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBox;
        private System.Windows.Forms.Button btnCmDel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
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
    }
}
