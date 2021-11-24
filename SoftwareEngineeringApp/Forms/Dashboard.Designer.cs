namespace SoftwareEngineeringApp.Forms
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.sitesCB = new System.Windows.Forms.ComboBox();
            this.nReports = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ListGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.allbtn = new System.Windows.Forms.Button();
            this.hundredBtn = new System.Windows.Forms.Button();
            this.tenBtn = new System.Windows.Forms.Button();
            this.downloadPDFBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 801);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.sitesCB);
            this.panel4.Controls.Add(this.nReports);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(843, 590);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Site:";
            // 
            // sitesCB
            // 
            this.sitesCB.FormattingEnabled = true;
            this.sitesCB.Location = new System.Drawing.Point(92, 89);
            this.sitesCB.Name = "sitesCB";
            this.sitesCB.Size = new System.Drawing.Size(175, 21);
            this.sitesCB.TabIndex = 27;
            this.sitesCB.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.sitesCB.TextChanged += new System.EventHandler(this.sitesCB_TextChanged);
            // 
            // nReports
            // 
            this.nReports.AutoSize = true;
            this.nReports.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.nReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.nReports.Location = new System.Drawing.Point(22, 531);
            this.nReports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nReports.Name = "nReports";
            this.nReports.Size = new System.Drawing.Size(234, 30);
            this.nReports.TabIndex = 25;
            this.nReports.Text = "Number of reports:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.flowLayoutPanel1.Controls.Add(this.ListGridView);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 124);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(791, 376);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // ListGridView
            // 
            this.ListGridView.AllowUserToAddRows = false;
            this.ListGridView.AllowUserToDeleteRows = false;
            this.ListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ListGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListGridView.ColumnHeadersHeight = 30;
            this.ListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListGridView.EnableHeadersVisualStyles = false;
            this.ListGridView.GridColor = System.Drawing.Color.SteelBlue;
            this.ListGridView.Location = new System.Drawing.Point(3, 3);
            this.ListGridView.Name = "ListGridView";
            this.ListGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListGridView.RowHeadersVisible = false;
            this.ListGridView.RowHeadersWidth = 51;
            this.ListGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ListGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListGridView.Size = new System.Drawing.Size(788, 373);
            this.ListGridView.TabIndex = 8;
            this.ListGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListGridView_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Reports List:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.btnStatistics);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(843, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 590);
            this.panel3.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.flowLayoutPanel2.Controls.Add(this.chart1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 127);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(38, 41, 38, 41);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(543, 376);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Sites";
            legend1.Title = "Site:";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(41, 44);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Sites";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(490, 303);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Name = "Title1";
            title1.Text = "N. Inspections";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Name = "Title2";
            title2.Text = "N. Intervents";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnStatistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistics.Location = new System.Drawing.Point(22, 34);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(178, 58);
            this.btnStatistics.TabIndex = 22;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.allbtn);
            this.panel5.Controls.Add(this.hundredBtn);
            this.panel5.Controls.Add(this.tenBtn);
            this.panel5.Controls.Add(this.downloadPDFBtn);
            this.panel5.Controls.Add(this.Exit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 730);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1418, 71);
            this.panel5.TabIndex = 4;
            // 
            // allbtn
            // 
            this.allbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.allbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allbtn.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.allbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.allbtn.Location = new System.Drawing.Point(385, 17);
            this.allbtn.Name = "allbtn";
            this.allbtn.Size = new System.Drawing.Size(86, 36);
            this.allbtn.TabIndex = 27;
            this.allbtn.Text = "All";
            this.allbtn.UseVisualStyleBackColor = false;
            this.allbtn.Click += new System.EventHandler(this.allbtn_Click);
            // 
            // hundredBtn
            // 
            this.hundredBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.hundredBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hundredBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hundredBtn.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.hundredBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.hundredBtn.Location = new System.Drawing.Point(293, 17);
            this.hundredBtn.Name = "hundredBtn";
            this.hundredBtn.Size = new System.Drawing.Size(86, 36);
            this.hundredBtn.TabIndex = 26;
            this.hundredBtn.Text = "x100";
            this.hundredBtn.UseVisualStyleBackColor = false;
            this.hundredBtn.Click += new System.EventHandler(this.hundredBtn_Click);
            // 
            // tenBtn
            // 
            this.tenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tenBtn.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.tenBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.tenBtn.Location = new System.Drawing.Point(201, 17);
            this.tenBtn.Name = "tenBtn";
            this.tenBtn.Size = new System.Drawing.Size(86, 36);
            this.tenBtn.TabIndex = 25;
            this.tenBtn.Text = "x10";
            this.tenBtn.UseVisualStyleBackColor = false;
            this.tenBtn.Click += new System.EventHandler(this.tenBtn_Click);
            // 
            // downloadPDFBtn
            // 
            this.downloadPDFBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.downloadPDFBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadPDFBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.downloadPDFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadPDFBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadPDFBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.downloadPDFBtn.Location = new System.Drawing.Point(0, 0);
            this.downloadPDFBtn.Name = "downloadPDFBtn";
            this.downloadPDFBtn.Size = new System.Drawing.Size(485, 71);
            this.downloadPDFBtn.TabIndex = 24;
            this.downloadPDFBtn.Text = "Save List Reports";
            this.downloadPDFBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downloadPDFBtn.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.Exit.Location = new System.Drawing.Point(1246, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(172, 71);
            this.Exit.TabIndex = 23;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1418, 140);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(517, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 801);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView ListGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button downloadPDFBtn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label nReports;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn auditIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interventionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actiontakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sitesCB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button allbtn;
        private System.Windows.Forms.Button hundredBtn;
        private System.Windows.Forms.Button tenBtn;
    }
}