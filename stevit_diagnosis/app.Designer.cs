﻿namespace stevit_diagnosis
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.symptomBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Configure = new System.Windows.Forms.Button();
            this.ConfigureTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Languages = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RequestBtn
            // 
            this.RequestBtn.Location = new System.Drawing.Point(219, 108);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(75, 23);
            this.RequestBtn.TabIndex = 0;
            this.RequestBtn.Text = "Request";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // symptomBox
            // 
            this.symptomBox.Location = new System.Drawing.Point(173, 82);
            this.symptomBox.Name = "symptomBox";
            this.symptomBox.Size = new System.Drawing.Size(121, 20);
            this.symptomBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comma separated symptom IDs";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(12, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(0, 13);
            this.nameLbl.TabIndex = 3;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(12, 144);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(136, 13);
            this.LinkLabel.TabIndex = 4;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Get the Id-s of all symptoms";
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current user:";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(85, 12);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 20);
            this.UserName.TabIndex = 7;
            // 
            // Configure
            // 
            this.Configure.Location = new System.Drawing.Point(191, 12);
            this.Configure.Name = "Configure";
            this.Configure.Size = new System.Drawing.Size(23, 22);
            this.Configure.TabIndex = 8;
            this.Configure.Text = "⚙";
            this.ConfigureTooltip.SetToolTip(this.Configure, "Configure user");
            this.Configure.UseVisualStyleBackColor = true;
            this.Configure.Click += new System.EventHandler(this.Configure_Click);
            // 
            // Languages
            // 
            this.Languages.FormattingEnabled = true;
            this.Languages.Items.AddRange(new object[] {
            "English",
            "Español",
            "Français",
            "Deutsche",
            "Italiano",
            "عربى",
            "Русский",
            "Türk",
            "Srpski",
            "Slovenskí"});
            this.Languages.Location = new System.Drawing.Point(220, 12);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(74, 21);
            this.Languages.TabIndex = 9;
            this.Languages.SelectedIndexChanged += new System.EventHandler(this.Languages_SelectedIndexChanged);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 166);
            this.Controls.Add(this.Languages);
            this.Controls.Add(this.Configure);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.symptomBox);
            this.Controls.Add(this.RequestBtn);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symptom Checker";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.TextBox symptomBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.LinkLabel LinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button Configure;
        private System.Windows.Forms.ToolTip ConfigureTooltip;
        private System.Windows.Forms.ComboBox Languages;
    }
}