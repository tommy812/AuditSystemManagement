﻿namespace SoftwareEngineeringApp.Forms
{
    partial class NewInspectionForm
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
            this.TitlePnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.AuditIDTxt = new System.Windows.Forms.TextBox();
            this.DateTxt = new System.Windows.Forms.TextBox();
            this.TypeTxt = new System.Windows.Forms.TextBox();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.SupervisorCB = new System.Windows.Forms.ComboBox();
            this.WorkAreaCB = new System.Windows.Forms.ComboBox();
            this.DescriptionLbl = new FontAwesome.Sharp.IconButton();
            this.WorkAreaLbl = new FontAwesome.Sharp.IconButton();
            this.SupervisorLbl = new FontAwesome.Sharp.IconButton();
            this.TypeLbl = new FontAwesome.Sharp.IconButton();
            this.DateLbl = new FontAwesome.Sharp.IconButton();
            this.AuditLbl = new FontAwesome.Sharp.IconButton();
            this.CancelBtn = new FontAwesome.Sharp.IconButton();
            this.StartBtn = new FontAwesome.Sharp.IconButton();
            this.TitlePnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePnl
            // 
            this.TitlePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.TitlePnl.Controls.Add(this.label1);
            this.TitlePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePnl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlePnl.Location = new System.Drawing.Point(0, 0);
            this.TitlePnl.Name = "TitlePnl";
            this.TitlePnl.Size = new System.Drawing.Size(1168, 140);
            this.TitlePnl.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(377, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW INSPECTION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Controls.Add(this.StartBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 550);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 94);
            this.panel2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 21);
            this.panel1.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AuditIDTxt);
            this.panel3.Controls.Add(this.AuditLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1168, 61);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DateTxt);
            this.panel4.Controls.Add(this.DateLbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1168, 59);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TypeTxt);
            this.panel5.Controls.Add(this.TypeLbl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 281);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1168, 58);
            this.panel5.TabIndex = 33;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.SupervisorCB);
            this.panel6.Controls.Add(this.SupervisorLbl);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 339);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1168, 64);
            this.panel6.TabIndex = 34;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.WorkAreaCB);
            this.panel7.Controls.Add(this.WorkAreaLbl);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 403);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1168, 64);
            this.panel7.TabIndex = 35;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.DescriptionTxt);
            this.panel8.Controls.Add(this.DescriptionLbl);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 467);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1168, 77);
            this.panel8.TabIndex = 36;
            // 
            // AuditIDTxt
            // 
            this.AuditIDTxt.Enabled = false;
            this.AuditIDTxt.Location = new System.Drawing.Point(482, 18);
            this.AuditIDTxt.Name = "AuditIDTxt";
            this.AuditIDTxt.Size = new System.Drawing.Size(338, 20);
            this.AuditIDTxt.TabIndex = 27;
            // 
            // DateTxt
            // 
            this.DateTxt.Enabled = false;
            this.DateTxt.Location = new System.Drawing.Point(482, 20);
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.Size = new System.Drawing.Size(338, 20);
            this.DateTxt.TabIndex = 28;
            // 
            // TypeTxt
            // 
            this.TypeTxt.Location = new System.Drawing.Point(482, 20);
            this.TypeTxt.Name = "TypeTxt";
            this.TypeTxt.Size = new System.Drawing.Size(338, 20);
            this.TypeTxt.TabIndex = 28;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(482, 12);
            this.DescriptionTxt.Multiline = true;
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(338, 41);
            this.DescriptionTxt.TabIndex = 28;
            // 
            // SupervisorCB
            // 
            this.SupervisorCB.FormattingEnabled = true;
            this.SupervisorCB.Location = new System.Drawing.Point(482, 20);
            this.SupervisorCB.Name = "SupervisorCB";
            this.SupervisorCB.Size = new System.Drawing.Size(338, 21);
            this.SupervisorCB.TabIndex = 27;
            this.SupervisorCB.Text = "Please Select.";
            // 
            // WorkAreaCB
            // 
            this.WorkAreaCB.FormattingEnabled = true;
            this.WorkAreaCB.Location = new System.Drawing.Point(482, 20);
            this.WorkAreaCB.Name = "WorkAreaCB";
            this.WorkAreaCB.Size = new System.Drawing.Size(338, 21);
            this.WorkAreaCB.TabIndex = 28;
            this.WorkAreaCB.Text = "Please Select.";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionLbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DescriptionLbl.FlatAppearance.BorderSize = 0;
            this.DescriptionLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.DescriptionLbl.ForeColor = System.Drawing.Color.White;
            this.DescriptionLbl.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DescriptionLbl.IconColor = System.Drawing.Color.Black;
            this.DescriptionLbl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DescriptionLbl.Location = new System.Drawing.Point(279, 12);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(167, 41);
            this.DescriptionLbl.TabIndex = 26;
            this.DescriptionLbl.Text = "Job Desciption:";
            this.DescriptionLbl.UseVisualStyleBackColor = false;
            // 
            // WorkAreaLbl
            // 
            this.WorkAreaLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WorkAreaLbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.WorkAreaLbl.FlatAppearance.BorderSize = 0;
            this.WorkAreaLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkAreaLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.WorkAreaLbl.ForeColor = System.Drawing.Color.White;
            this.WorkAreaLbl.IconChar = FontAwesome.Sharp.IconChar.None;
            this.WorkAreaLbl.IconColor = System.Drawing.Color.Black;
            this.WorkAreaLbl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.WorkAreaLbl.Location = new System.Drawing.Point(279, 6);
            this.WorkAreaLbl.Name = "WorkAreaLbl";
            this.WorkAreaLbl.Size = new System.Drawing.Size(167, 41);
            this.WorkAreaLbl.TabIndex = 26;
            this.WorkAreaLbl.Text = "Work Area:";
            this.WorkAreaLbl.UseVisualStyleBackColor = false;
            // 
            // SupervisorLbl
            // 
            this.SupervisorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SupervisorLbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SupervisorLbl.FlatAppearance.BorderSize = 0;
            this.SupervisorLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupervisorLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.SupervisorLbl.ForeColor = System.Drawing.Color.White;
            this.SupervisorLbl.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SupervisorLbl.IconColor = System.Drawing.Color.Black;
            this.SupervisorLbl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SupervisorLbl.Location = new System.Drawing.Point(279, 6);
            this.SupervisorLbl.Name = "SupervisorLbl";
            this.SupervisorLbl.Size = new System.Drawing.Size(167, 41);
            this.SupervisorLbl.TabIndex = 26;
            this.SupervisorLbl.Text = "Supervisor:";
            this.SupervisorLbl.UseVisualStyleBackColor = false;
            // 
            // TypeLbl
            // 
            this.TypeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeLbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TypeLbl.FlatAppearance.BorderSize = 0;
            this.TypeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.TypeLbl.ForeColor = System.Drawing.Color.White;
            this.TypeLbl.IconChar = FontAwesome.Sharp.IconChar.None;
            this.TypeLbl.IconColor = System.Drawing.Color.Black;
            this.TypeLbl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TypeLbl.Location = new System.Drawing.Point(279, 6);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(167, 41);
            this.TypeLbl.TabIndex = 26;
            this.TypeLbl.Text = "Type:";
            this.TypeLbl.UseVisualStyleBackColor = false;
            // 
            // DateLbl
            // 
            this.DateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateLbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DateLbl.FlatAppearance.BorderSize = 0;
            this.DateLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.DateLbl.ForeColor = System.Drawing.Color.White;
            this.DateLbl.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DateLbl.IconColor = System.Drawing.Color.Black;
            this.DateLbl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DateLbl.Location = new System.Drawing.Point(279, 6);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(167, 41);
            this.DateLbl.TabIndex = 26;
            this.DateLbl.Text = "Date:";
            this.DateLbl.UseVisualStyleBackColor = false;
            // 
            // AuditLbl
            // 
            this.AuditLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuditLbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AuditLbl.FlatAppearance.BorderSize = 0;
            this.AuditLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuditLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.AuditLbl.ForeColor = System.Drawing.Color.White;
            this.AuditLbl.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AuditLbl.IconColor = System.Drawing.Color.Black;
            this.AuditLbl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AuditLbl.Location = new System.Drawing.Point(279, 6);
            this.AuditLbl.Name = "AuditLbl";
            this.AuditLbl.Size = new System.Drawing.Size(167, 41);
            this.AuditLbl.TabIndex = 26;
            this.AuditLbl.Text = "Audit ID:";
            this.AuditLbl.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CancelBtn.IconColor = System.Drawing.Color.Black;
            this.CancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelBtn.Location = new System.Drawing.Point(0, 0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(192, 94);
            this.CancelBtn.TabIndex = 23;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Visible = false;
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.StartBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.StartBtn.FlatAppearance.BorderSize = 0;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.StartBtn.IconColor = System.Drawing.Color.Black;
            this.StartBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StartBtn.Location = new System.Drawing.Point(976, 0);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(192, 94);
            this.StartBtn.TabIndex = 22;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            // 
            // NewInspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 644);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TitlePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewInspectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewInspectionForm";
            this.TitlePnl.ResumeLayout(false);
            this.TitlePnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton CancelBtn;
        private FontAwesome.Sharp.IconButton StartBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox AuditIDTxt;
        private FontAwesome.Sharp.IconButton AuditLbl;
        private System.Windows.Forms.TextBox DateTxt;
        private FontAwesome.Sharp.IconButton DateLbl;
        private System.Windows.Forms.TextBox TypeTxt;
        private FontAwesome.Sharp.IconButton TypeLbl;
        private System.Windows.Forms.ComboBox SupervisorCB;
        private FontAwesome.Sharp.IconButton SupervisorLbl;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox WorkAreaCB;
        private FontAwesome.Sharp.IconButton WorkAreaLbl;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private FontAwesome.Sharp.IconButton DescriptionLbl;
    }
}