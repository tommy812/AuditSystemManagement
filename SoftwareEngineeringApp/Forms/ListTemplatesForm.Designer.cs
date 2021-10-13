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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.software_EngineerDataSet = new SoftwareEngineeringApp.Software_EngineerDataSet();
            this.auditcategoryresultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.audit_category_resultsTableAdapter = new SoftwareEngineeringApp.Software_EngineerDataSetTableAdapters.Audit_category_resultsTableAdapter();
            this.TemplatesGridView = new System.Windows.Forms.DataGridView();
            this.software_EngineerDataSet2 = new SoftwareEngineeringApp.Software_EngineerDataSet2();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templateTableAdapter = new SoftwareEngineeringApp.Software_EngineerDataSet2TableAdapters.TemplateTableAdapter();
            this.templateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templatenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectTemplateLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoriesLbl = new System.Windows.Forms.Label();
            this.CategoriesGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.software_EngineerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditcategoryresultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemplatesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.software_EngineerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 140);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(311, 48);
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
            this.TemplatesGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.TemplatesGridView.Location = new System.Drawing.Point(60, 235);
            this.TemplatesGridView.Name = "TemplatesGridView";
            this.TemplatesGridView.ReadOnly = true;
            this.TemplatesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TemplatesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TemplatesGridView.Size = new System.Drawing.Size(318, 98);
            this.TemplatesGridView.TabIndex = 1;
            this.TemplatesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TemplatesGridView_CellClick);
            // 
            // software_EngineerDataSet2
            // 
            this.software_EngineerDataSet2.DataSetName = "Software_EngineerDataSet2";
            this.software_EngineerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // templateBindingSource
            // 
            this.templateBindingSource.DataMember = "Template";
            this.templateBindingSource.DataSource = this.software_EngineerDataSet2;
            // 
            // templateTableAdapter
            // 
            this.templateTableAdapter.ClearBeforeFill = true;
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
            // SelectTemplateLbl
            // 
            this.SelectTemplateLbl.AutoSize = true;
            this.SelectTemplateLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTemplateLbl.Location = new System.Drawing.Point(13, 163);
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
            this.CategoriesLbl.AutoSize = true;
            this.CategoriesLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesLbl.Location = new System.Drawing.Point(446, 163);
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
            this.CategoriesGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoriesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CategoriesGridView.Location = new System.Drawing.Point(450, 235);
            this.CategoriesGridView.Name = "CategoriesGridView";
            this.CategoriesGridView.ReadOnly = true;
            this.CategoriesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CategoriesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesGridView.Size = new System.Drawing.Size(318, 98);
            this.CategoriesGridView.TabIndex = 5;
            this.CategoriesGridView.Visible = false;
            // 
            // ListTemplatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1006, 679);
            this.Controls.Add(this.CategoriesGridView);
            this.Controls.Add(this.CategoriesLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectTemplateLbl);
            this.Controls.Add(this.TemplatesGridView);
            this.Controls.Add(this.panel1);
            this.Name = "ListTemplatesForm";
            this.Text = "ListTemplates";
            this.Load += new System.EventHandler(this.ListTemplatesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.software_EngineerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditcategoryresultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemplatesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.software_EngineerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView)).EndInit();
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
    }
}