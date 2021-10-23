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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTemplateLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoriesLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContinueBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TemplateGrid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CategoryGrid = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.QuestionGrid = new System.Windows.Forms.DataGridView();
            this.QuestionsLbl = new System.Windows.Forms.Label();
            this.InspectionTemplatePnl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TemplateGrid)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGrid)).BeginInit();
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
            this.SelectTemplateLbl.Location = new System.Drawing.Point(3, 97);
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
            this.CategoriesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoriesLbl.AutoSize = true;
            this.CategoriesLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CategoriesLbl.Location = new System.Drawing.Point(7, 97);
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
            this.panel3.Controls.Add(this.TemplateGrid);
            this.panel3.Controls.Add(this.SelectTemplateLbl);
            this.panel3.Location = new System.Drawing.Point(12, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 543);
            this.panel3.TabIndex = 7;
            // 
            // TemplateGrid
            // 
            this.TemplateGrid.AllowUserToAddRows = false;
            this.TemplateGrid.AllowUserToDeleteRows = false;
            this.TemplateGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TemplateGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.TemplateGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TemplateGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TemplateGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TemplateGrid.ColumnHeadersHeight = 30;
            this.TemplateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TemplateGrid.EnableHeadersVisualStyles = false;
            this.TemplateGrid.GridColor = System.Drawing.Color.SteelBlue;
            this.TemplateGrid.Location = new System.Drawing.Point(7, 148);
            this.TemplateGrid.Name = "TemplateGrid";
            this.TemplateGrid.ReadOnly = true;
            this.TemplateGrid.RowHeadersVisible = false;
            this.TemplateGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.TemplateGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TemplateGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TemplateGrid.Size = new System.Drawing.Size(345, 294);
            this.TemplateGrid.TabIndex = 3;
            this.TemplateGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TemplateGrid_CellClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.Controls.Add(this.CategoryGrid);
            this.panel4.Controls.Add(this.CategoriesLbl);
            this.panel4.Location = new System.Drawing.Point(407, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 543);
            this.panel4.TabIndex = 8;
            // 
            // CategoryGrid
            // 
            this.CategoryGrid.AllowUserToAddRows = false;
            this.CategoryGrid.AllowUserToDeleteRows = false;
            this.CategoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.CategoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CategoryGrid.ColumnHeadersHeight = 30;
            this.CategoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CategoryGrid.EnableHeadersVisualStyles = false;
            this.CategoryGrid.GridColor = System.Drawing.Color.SteelBlue;
            this.CategoryGrid.Location = new System.Drawing.Point(0, 148);
            this.CategoryGrid.Name = "CategoryGrid";
            this.CategoryGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryGrid.RowHeadersVisible = false;
            this.CategoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.CategoryGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CategoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryGrid.Size = new System.Drawing.Size(345, 294);
            this.CategoryGrid.TabIndex = 5;
            this.CategoryGrid.Visible = false;
            this.CategoryGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGrid_CellClick);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.QuestionGrid);
            this.panel5.Controls.Add(this.QuestionsLbl);
            this.panel5.Location = new System.Drawing.Point(773, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(377, 543);
            this.panel5.TabIndex = 9;
            // 
            // QuestionGrid
            // 
            this.QuestionGrid.AllowUserToAddRows = false;
            this.QuestionGrid.AllowUserToDeleteRows = false;
            this.QuestionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QuestionGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.QuestionGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.QuestionGrid.ColumnHeadersHeight = 30;
            this.QuestionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.QuestionGrid.EnableHeadersVisualStyles = false;
            this.QuestionGrid.GridColor = System.Drawing.Color.SteelBlue;
            this.QuestionGrid.Location = new System.Drawing.Point(13, 148);
            this.QuestionGrid.Name = "QuestionGrid";
            this.QuestionGrid.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.QuestionGrid.RowHeadersVisible = false;
            this.QuestionGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.QuestionGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.QuestionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuestionGrid.Size = new System.Drawing.Size(345, 294);
            this.QuestionGrid.TabIndex = 6;
            this.QuestionGrid.Visible = false;
            // 
            // QuestionsLbl
            // 
            this.QuestionsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QuestionsLbl.AutoSize = true;
            this.QuestionsLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.QuestionsLbl.Location = new System.Drawing.Point(9, 97);
            this.QuestionsLbl.Name = "QuestionsLbl";
            this.QuestionsLbl.Size = new System.Drawing.Size(104, 23);
            this.QuestionsLbl.TabIndex = 5;
            this.QuestionsLbl.Text = "Questions:";
            this.QuestionsLbl.Visible = false;
            // 
            // InspectionTemplatePnl
            // 
            this.InspectionTemplatePnl.BackColor = System.Drawing.Color.LightSteelBlue;
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
            ((System.ComponentModel.ISupportInitialize)(this.TemplateGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGrid)).EndInit();
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
        private System.Windows.Forms.DataGridView TemplateGrid;
        private System.Windows.Forms.DataGridView CategoryGrid;
        private System.Windows.Forms.DataGridView QuestionGrid;
    }
}