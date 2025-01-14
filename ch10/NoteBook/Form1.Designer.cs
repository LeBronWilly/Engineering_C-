﻿namespace NoteBook
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboBgColor = new System.Windows.Forms.ComboBox();
            this.cboForeColor = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(149, 178);
            this.rtbText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(639, 230);
            this.rtbText.TabIndex = 32;
            this.rtbText.Text = "";
            this.rtbText.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbText_LinkClicked);
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Items.AddRange(new object[] {
            "新細明體",
            "微軟正黑體",
            "標楷體"});
            this.cboFont.Location = new System.Drawing.Point(671, 94);
            this.cboFont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(116, 23);
            this.cboFont.TabIndex = 28;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.cboSize.Location = new System.Drawing.Point(518, 92);
            this.cboSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(61, 23);
            this.cboSize.TabIndex = 29;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // cboBgColor
            // 
            this.cboBgColor.FormattingEnabled = true;
            this.cboBgColor.Items.AddRange(new object[] {
            "灰",
            "淺紅",
            "淺綠"});
            this.cboBgColor.Location = new System.Drawing.Point(367, 92);
            this.cboBgColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboBgColor.Name = "cboBgColor";
            this.cboBgColor.Size = new System.Drawing.Size(61, 23);
            this.cboBgColor.TabIndex = 30;
            this.cboBgColor.SelectedIndexChanged += new System.EventHandler(this.cboBgColor_SelectedIndexChanged);
            // 
            // cboForeColor
            // 
            this.cboForeColor.FormattingEnabled = true;
            this.cboForeColor.Items.AddRange(new object[] {
            "黑",
            "紅",
            "藍"});
            this.cboForeColor.Location = new System.Drawing.Point(209, 92);
            this.cboForeColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboForeColor.Name = "cboForeColor";
            this.cboForeColor.Size = new System.Drawing.Size(61, 23);
            this.cboForeColor.TabIndex = 31;
            this.cboForeColor.SelectedIndexChanged += new System.EventHandler(this.cboForeColor_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(383, 136);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 29);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "清除選取的文字";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(149, 136);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 29);
            this.btnOpen.TabIndex = 26;
            this.btnOpen.Text = "開檔";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(263, 136);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 29);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "存檔";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "字體：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "大小：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "背景色：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "前景色：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 29);
            this.button1.TabIndex = 33;
            this.button1.Text = "清除所有文字";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.cboFont);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.cboBgColor);
            this.Controls.Add(this.cboForeColor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ComboBox cboBgColor;
        private System.Windows.Forms.ComboBox cboForeColor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

