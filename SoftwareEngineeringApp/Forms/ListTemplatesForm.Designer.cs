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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.software_EngineerDataSet = new SoftwareEngineeringApp.Software_EngineerDataSet();
            this.auditcategoryresultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.audit_category_resultsTableAdapter = new SoftwareEngineeringApp.Software_EngineerDataSetTableAdapters.Audit_category_resultsTableAdapter();
            this.TemplatesGridView = new System.Windows.Forms.DataGridView();
            this.templateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templatenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.software_EngineerDataSet2 = new SoftwareEngineeringApp.Software_EngineerDataSet2();
            this.templateTableAdapter = new SoftwareEngineeringApp.Software_EngineerDataSet2TableAdapters.TemplateTableAdapter();
            this.SelectTemplateLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoriesLbl = new System.Windows.Forms.Label();
            this.CategoriesGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContinueBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.QuestionsDataGrid = new System.Windows.Forms.DataGridView();
            this.QuestionsLbl = new System.Windows.Forms.Label();
            this.InspectionTemplatePnl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.software_EngineerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditcategoryresultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemplatesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.software_EngineerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDataGrid)).BeginInit();
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
            // software_EngineerDataSet
            // 
            this.software_EngineerDataSet.DataSetName = "Software_EngineerDataSet";
            this.software_EngineerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditcategoryresultsBindingSource
            // 
            this.auditcategoryresultsBindingSource.DataMember = "Audit_category_results";
            this.auditcategoryresultsBindingSource.DataSource = this.software_EngineerDataSet;
            // 
            // audit_category_resultsTableAdapter
            // 
            this.audit_category_resultsTableAdapter.ClearBeforeFill = true;
            // 
            // TemplatesGridView
            // 
            this.TemplatesGridView.AllowUserToDeleteRows = false;
            this.TemplatesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplatesGridView.AutoGenerateColumns = false;
            this.TemplatesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TemplatesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.templateIDDataGridViewTextBoxColumn,
            this.templatenameDataGridViewTextBoxColumn});
            this.TemplatesGridView.DataSource = this.templateBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TemplatesGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.TemplatesGridView.Location = new System.Drawing.Point(0, 151);
            this.TemplatesGridView.Name = "TemplatesGridView";
            this.TemplatesGridView.ReadOnly = true;
            this.TemplatesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TemplatesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TemplatesGridView.Size = new System.Drawing.Size(360, 300);
            this.TemplatesGridView.TabIndex = 1;
            this.TemplatesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TemplatesGridView_CellClick);
            // 
            // templateIDDataGridViewTextBoxColumn
            // 
            this.templateIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.templateIDDataGridViewTextBoxColumn.DataPropertyName = "Template_ID";
            this.templateIDDataGridViewTextBoxColumn.HeaderText = "Template_ID";
            this.templateIDDataGridViewTextBoxColumn.Name = "templateIDDataGridViewTextBoxColumn";
            this.templateIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // templatenameDataGridViewTextBoxColumn
            // 
            this.templatenameDataGridViewTextBoxColumn.DataPropertyName = "Template_name";
            this.templatenameDataGridViewTextBoxColumn.HeaderText = "Template_name";
            this.templatenameDataGridViewTextBoxColumn.Name = "templatenameDataGridViewTextBoxColumn";
            this.templatenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // templateBindingSource
            // 
            this.templateBindingSource.DataMember = "Template";
            this.templateBindingSource.DataSource = this.software_EngineerDataSet2;
            // 
            // software_EngineerDataSet2
            // 
            this.software_EngineerDataSet2.DataSetName = "Software_EngineerDataSet2";
            this.software_EngineerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // templateTableAdapter
            // 
            this.templateTableAdapter.ClearBeforeFill = true;
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
            // CategoriesGridView
            // 
            this.CategoriesGridView.AllowUserToDeleteRows = false;
            this.CategoriesGridView.AllowUserToOrderColumns = true;
            this.CategoriesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoriesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriesGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.CategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoriesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CategoriesGridView.Location = new System.Drawing.Point(3, 151);
            this.CategoriesGridView.Name = "CategoriesGridView";
            this.CategoriesGridView.ReadOnly = true;
            this.CategoriesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CategoriesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesGridView.Size = new System.Drawing.Size(333, 330);
            this.CategoriesGridView.TabIndex = 5;
            this.CategoriesGridView.Visible = false;
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
            this.panel3.Controls.Add(this.TemplatesGridView);
            this.panel3.Controls.Add(this.SelectTemplateLbl);
            this.panel3.Location = new System.Drawing.Point(12, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 543);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.Controls.Add(this.CategoriesGridView);
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
            this.panel5.Controls.Add(this.QuestionsDataGrid);
            this.panel5.Controls.Add(this.QuestionsLbl);
            this.panel5.Location = new System.Drawing.Point(773, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(377, 543);
            this.panel5.TabIndex = 9;
            // 
            // QuestionsDataGrid
            // 
            this.QuestionsDataGrid.AllowUserToDeleteRows = false;
            this.QuestionsDataGrid.AllowUserToOrderColumns = true;
            this.QuestionsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QuestionsDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.QuestionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuestionsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.QuestionsDataGrid.Location = new System.Drawing.Point(18, 151);
            this.QuestionsDataGrid.Name = "QuestionsDataGrid";
            this.QuestionsDataGrid.ReadOnly = true;
            this.QuestionsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.QuestionsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuestionsDataGrid.Size = new System.Drawing.Size(347, 330);
            this.QuestionsDataGrid.TabIndex = 6;
            this.QuestionsDataGrid.Visible = false;
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
            this.Load += new System.EventHandler(this.ListTemplatesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.software_EngineerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditcategoryresultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemplatesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.software_EngineerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDataGrid)).EndInit();
            this.InspectionTemplatePnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Software_EngineerDataSet software_EngineerDataSet;
        private System.Windows.Forms.BindingSource auditcategoryresultsBindingSource;
        private Software_EngineerDataSetTableAdapters.Audit_category_resultsTableAdapter audit_category_resultsTableAdapter;
        private System.Windows.Forms.DataGridView TemplatesGridView;
        private Software_EngineerDataSet2 software_EngineerDataSet2;
        private System.Windows.Forms.BindingSource templateBindingSource;
        private Software_EngineerDataSet2TableAdapters.TemplateTableAdapter templateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templatenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label SelectTemplateLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CategoriesLbl;
        private System.Windows.Forms.DataGridView CategoriesGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public FontAwesome.Sharp.IconButton ContinueBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView QuestionsDataGrid;
        private System.Windows.Forms.Label QuestionsLbl;
        private System.Windows.Forms.Panel InspectionTemplatePnl;
    }
}