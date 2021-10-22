namespace SoftwareEngineeringApp.Forms
{
    partial class ListTemplatesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTemplateLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoriesLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContinueBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.QuestionsLbl = new System.Windows.Forms.Label();
            this.InspectionTemplatePnl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.InspectionTemplatePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 140);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(383, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inspection Templates";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
        
            // SelectTemplateLbl
            // 
            this.SelectTemplateLbl.AutoSize = true;
            this.SelectTemplateLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTemplateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SelectTemplateLbl.Location = new System.Drawing.Point(3, 99);
            this.SelectTemplateLbl.Name = "SelectTemplateLbl";
            this.SelectTemplateLbl.Size = new System.Drawing.Size(159, 23);
            this.SelectTemplateLbl.TabIndex = 2;
            this.SelectTemplateLbl.Text = "Select Template";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // CategoriesLbl
            // 
            this.CategoriesLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoriesLbl.AutoSize = true;
            this.CategoriesLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CategoriesLbl.Location = new System.Drawing.Point(3, 97);
            this.CategoriesLbl.Name = "CategoriesLbl";
            this.CategoriesLbl.Size = new System.Drawing.Size(193, 23);
            this.CategoriesLbl.TabIndex = 4;
            this.CategoriesLbl.Text = "Categories Icluded:";
            this.CategoriesLbl.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ContinueBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 687);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 94);
            this.panel2.TabIndex = 6;
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ContinueBtn.CausesValidation = false;
            this.ContinueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContinueBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContinueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueBtn.ForeColor = System.Drawing.Color.White;
            this.ContinueBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ContinueBtn.IconColor = System.Drawing.Color.Black;
            this.ContinueBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ContinueBtn.Location = new System.Drawing.Point(985, 0);
            this.ContinueBtn.MinimumSize = new System.Drawing.Size(165, 53);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(165, 94);
            this.ContinueBtn.TabIndex = 0;
            this.ContinueBtn.Text = "Continue";
            this.ContinueBtn.UseVisualStyleBackColor = false;
            this.ContinueBtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.SelectTemplateLbl);
            this.panel3.Location = new System.Drawing.Point(12, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 543);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.Controls.Add(this.CategoriesLbl);
            this.panel4.Location = new System.Drawing.Point(407, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 543);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.QuestionsLbl);
            this.panel5.Location = new System.Drawing.Point(773, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(377, 543);
            this.panel5.TabIndex = 9;
            // 
            // QuestionsLbl
            // 
            this.QuestionsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionsLbl.AutoSize = true;
            this.QuestionsLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.QuestionsLbl.Location = new System.Drawing.Point(25, 97);
            this.QuestionsLbl.Name = "QuestionsLbl";
            this.QuestionsLbl.Size = new System.Drawing.Size(104, 23);
            this.QuestionsLbl.TabIndex = 5;
            this.QuestionsLbl.Text = "Questions:";
            this.QuestionsLbl.Visible = false;
            // 
            // InspectionTemplatePnl
            // 
            this.InspectionTemplatePnl.Controls.Add(this.panel1);
            this.InspectionTemplatePnl.Controls.Add(this.panel2);
            this.InspectionTemplatePnl.Controls.Add(this.panel5);
            this.InspectionTemplatePnl.Controls.Add(this.panel3);
            this.InspectionTemplatePnl.Controls.Add(this.panel4);
            this.InspectionTemplatePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectionTemplatePnl.Location = new System.Drawing.Point(0, 0);
            this.InspectionTemplatePnl.Name = "InspectionTemplatePnl";
            this.InspectionTemplatePnl.Size = new System.Drawing.Size(1150, 781);
            this.InspectionTemplatePnl.TabIndex = 10;
            // 
            // ListTemplatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1150, 781);
            this.Controls.Add(this.InspectionTemplatePnl);
            this.Controls.Add(this.label3);
            this.Name = "ListTemplatesForm";
            this.Text = "ListTemplates";

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.InspectionTemplatePnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectTemplateLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CategoriesLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public FontAwesome.Sharp.IconButton ContinueBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label QuestionsLbl;
        private System.Windows.Forms.Panel InspectionTemplatePnl;
    }
}