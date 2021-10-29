namespace SoftwareEngineeringApp.Forms
{
    partial class InspectionForm
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
            this.TitlePnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameTxt = new System.Windows.Forms.Label();
            this.CommentTxtBx = new System.Windows.Forms.TextBox();
            this.NextBtn = new FontAwesome.Sharp.IconButton();
            this.QuestionLbl = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SubmitBtn = new FontAwesome.Sharp.IconButton();
            this.PreviousBtn = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.QuestionGrid = new System.Windows.Forms.DataGridView();
            this.CategoryLbl = new FontAwesome.Sharp.IconButton();
            this.InterventionTxt = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.UploadImageBtn = new FontAwesome.Sharp.IconButton();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.CompletedTxt = new FontAwesome.Sharp.IconButton();
            this.interventiontxtbx = new System.Windows.Forms.TextBox();
            this.ActionTakenTxtBx = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActionsLbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CommentLbl = new System.Windows.Forms.Label();
            this.TitlePnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.TitlePnl.Size = new System.Drawing.Size(1229, 140);
            this.TitlePnl.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(407, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSPECTION PAGE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileNameTxt
            // 
            this.FileNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileNameTxt.AutoSize = true;
            this.FileNameTxt.Location = new System.Drawing.Point(718, 49);
            this.FileNameTxt.Name = "FileNameTxt";
            this.FileNameTxt.Size = new System.Drawing.Size(51, 13);
            this.FileNameTxt.TabIndex = 26;
            this.FileNameTxt.Text = "FileName";
            // 
            // CommentTxtBx
            // 
            this.CommentTxtBx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CommentTxtBx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentTxtBx.Location = new System.Drawing.Point(49, 35);
            this.CommentTxtBx.Multiline = true;
            this.CommentTxtBx.Name = "CommentTxtBx";
            this.CommentTxtBx.Size = new System.Drawing.Size(723, 91);
            this.CommentTxtBx.TabIndex = 23;
            this.CommentTxtBx.Text = "Comments";
            this.CommentTxtBx.Click += new System.EventHandler(this.CommentTxtBx_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.NextBtn.ForeColor = System.Drawing.Color.White;
            this.NextBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.NextBtn.IconColor = System.Drawing.Color.Black;
            this.NextBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NextBtn.Location = new System.Drawing.Point(1037, 0);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(192, 88);
            this.NextBtn.TabIndex = 22;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // QuestionLbl
            // 
            this.QuestionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.QuestionLbl.FlatAppearance.BorderSize = 0;
            this.QuestionLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.QuestionLbl.ForeColor = System.Drawing.Color.White;
            this.QuestionLbl.IconChar = FontAwesome.Sharp.IconChar.None;
            this.QuestionLbl.IconColor = System.Drawing.Color.Black;
            this.QuestionLbl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.QuestionLbl.Location = new System.Drawing.Point(49, 19);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(723, 55);
            this.QuestionLbl.TabIndex = 17;
            this.QuestionLbl.Text = "Question";
            this.QuestionLbl.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(-117, 89);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 43);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.Text = "sectionButton";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.SubmitBtn);
            this.panel2.Controls.Add(this.PreviousBtn);
            this.panel2.Controls.Add(this.NextBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 693);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1229, 88);
            this.panel2.TabIndex = 28;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmitBtn.IconColor = System.Drawing.Color.Black;
            this.SubmitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmitBtn.Location = new System.Drawing.Point(535, 0);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(192, 91);
            this.SubmitBtn.TabIndex = 24;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Visible = false;
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.PreviousBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.PreviousBtn.ForeColor = System.Drawing.Color.White;
            this.PreviousBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.PreviousBtn.IconColor = System.Drawing.Color.Black;
            this.PreviousBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PreviousBtn.Location = new System.Drawing.Point(0, 0);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(192, 88);
            this.PreviousBtn.TabIndex = 23;
            this.PreviousBtn.Text = "Previous";
            this.PreviousBtn.UseVisualStyleBackColor = false;
            this.PreviousBtn.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.QuestionGrid);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 140);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(445, 553);
            this.panel8.TabIndex = 29;
            // 
            // QuestionGrid
            // 
            this.QuestionGrid.AllowUserToAddRows = false;
            this.QuestionGrid.AllowUserToDeleteRows = false;
            this.QuestionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QuestionGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.QuestionGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.QuestionGrid.ColumnHeadersHeight = 30;
            this.QuestionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.QuestionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionGrid.EnableHeadersVisualStyles = false;
            this.QuestionGrid.GridColor = System.Drawing.Color.SteelBlue;
            this.QuestionGrid.Location = new System.Drawing.Point(0, 0);
            this.QuestionGrid.Name = "QuestionGrid";
            this.QuestionGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.QuestionGrid.RowHeadersVisible = false;
            this.QuestionGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.QuestionGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.QuestionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuestionGrid.Size = new System.Drawing.Size(445, 553);
            this.QuestionGrid.TabIndex = 7;
            this.QuestionGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuestionGrid_CellClick);
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoryLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.CategoryLbl.FlatAppearance.BorderSize = 0;
            this.CategoryLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.CategoryLbl.ForeColor = System.Drawing.Color.White;
            this.CategoryLbl.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CategoryLbl.IconColor = System.Drawing.Color.Black;
            this.CategoryLbl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CategoryLbl.Location = new System.Drawing.Point(49, 20);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(723, 55);
            this.CategoryLbl.TabIndex = 17;
            this.CategoryLbl.Text = "Category";
            this.CategoryLbl.UseVisualStyleBackColor = false;
            // 
            // InterventionTxt
            // 
            this.InterventionTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InterventionTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.InterventionTxt.FlatAppearance.BorderSize = 0;
            this.InterventionTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InterventionTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.InterventionTxt.ForeColor = System.Drawing.Color.White;
            this.InterventionTxt.IconChar = FontAwesome.Sharp.IconChar.None;
            this.InterventionTxt.IconColor = System.Drawing.Color.Black;
            this.InterventionTxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InterventionTxt.Location = new System.Drawing.Point(52, 21);
            this.InterventionTxt.Name = "InterventionTxt";
            this.InterventionTxt.Size = new System.Drawing.Size(167, 41);
            this.InterventionTxt.TabIndex = 18;
            this.InterventionTxt.Text = "Interventions";
            this.InterventionTxt.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CategoryLbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(445, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 81);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.QuestionLbl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(445, 221);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 80);
            this.panel5.TabIndex = 31;
            // 
            // UploadImageBtn
            // 
            this.UploadImageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UploadImageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.UploadImageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadImageBtn.FlatAppearance.BorderSize = 0;
            this.UploadImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadImageBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.UploadImageBtn.ForeColor = System.Drawing.Color.White;
            this.UploadImageBtn.IconChar = FontAwesome.Sharp.IconChar.GalacticRepublic;
            this.UploadImageBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.UploadImageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UploadImageBtn.Location = new System.Drawing.Point(545, 21);
            this.UploadImageBtn.Name = "UploadImageBtn";
            this.UploadImageBtn.Size = new System.Drawing.Size(167, 41);
            this.UploadImageBtn.TabIndex = 27;
            this.UploadImageBtn.Text = "Upload Image";
            this.UploadImageBtn.UseVisualStyleBackColor = false;
            // 
            // checkBox
            // 
            this.checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox.Location = new System.Drawing.Point(507, 21);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(19, 41);
            this.checkBox.TabIndex = 26;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // CompletedTxt
            // 
            this.CompletedTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CompletedTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.CompletedTxt.FlatAppearance.BorderSize = 0;
            this.CompletedTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompletedTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.CompletedTxt.ForeColor = System.Drawing.Color.White;
            this.CompletedTxt.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CompletedTxt.IconColor = System.Drawing.Color.Black;
            this.CompletedTxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CompletedTxt.Location = new System.Drawing.Point(334, 21);
            this.CompletedTxt.Name = "CompletedTxt";
            this.CompletedTxt.Size = new System.Drawing.Size(167, 41);
            this.CompletedTxt.TabIndex = 25;
            this.CompletedTxt.Text = "Completed";
            this.CompletedTxt.UseVisualStyleBackColor = false;
            // 
            // interventiontxtbx
            // 
            this.interventiontxtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.interventiontxtbx.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interventiontxtbx.Location = new System.Drawing.Point(250, 21);
            this.interventiontxtbx.MaxLength = 100;
            this.interventiontxtbx.Multiline = true;
            this.interventiontxtbx.Name = "interventiontxtbx";
            this.interventiontxtbx.Size = new System.Drawing.Size(55, 41);
            this.interventiontxtbx.TabIndex = 24;
            this.interventiontxtbx.Text = "1";
            this.interventiontxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ActionTakenTxtBx
            // 
            this.ActionTakenTxtBx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActionTakenTxtBx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionTakenTxtBx.Location = new System.Drawing.Point(49, 38);
            this.ActionTakenTxtBx.Multiline = true;
            this.ActionTakenTxtBx.Name = "ActionTakenTxtBx";
            this.ActionTakenTxtBx.Size = new System.Drawing.Size(723, 91);
            this.ActionTakenTxtBx.TabIndex = 24;
            this.ActionTakenTxtBx.Text = "Action Taken";
            this.ActionTakenTxtBx.Click += new System.EventHandler(this.ActionTakenTxtBx_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.UploadImageBtn);
            this.panel6.Controls.Add(this.checkBox);
            this.panel6.Controls.Add(this.FileNameTxt);
            this.panel6.Controls.Add(this.CompletedTxt);
            this.panel6.Controls.Add(this.InterventionTxt);
            this.panel6.Controls.Add(this.interventiontxtbx);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(445, 301);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(784, 87);
            this.panel6.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ActionsLbl);
            this.panel1.Controls.Add(this.ActionTakenTxtBx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(445, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 135);
            this.panel1.TabIndex = 30;
            // 
            // ActionsLbl
            // 
            this.ActionsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ActionsLbl.AutoSize = true;
            this.ActionsLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ActionsLbl.Location = new System.Drawing.Point(45, 12);
            this.ActionsLbl.Name = "ActionsLbl";
            this.ActionsLbl.Size = new System.Drawing.Size(148, 23);
            this.ActionsLbl.TabIndex = 25;
            this.ActionsLbl.Text = "Actions Taken: ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.CommentLbl);
            this.panel7.Controls.Add(this.CommentTxtBx);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(445, 523);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(784, 164);
            this.panel7.TabIndex = 33;
            // 
            // CommentLbl
            // 
            this.CommentLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CommentLbl.AutoSize = true;
            this.CommentLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CommentLbl.Location = new System.Drawing.Point(50, 9);
            this.CommentLbl.Name = "CommentLbl";
            this.CommentLbl.Size = new System.Drawing.Size(115, 23);
            this.CommentLbl.TabIndex = 24;
            this.CommentLbl.Text = "Comments:";
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1229, 781);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TitlePnl);
            this.Controls.Add(this.iconButton1);
            this.MinimumSize = new System.Drawing.Size(816, 820);
            this.Name = "InspectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inspectionForm";
            this.TitlePnl.ResumeLayout(false);
            this.TitlePnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FileNameTxt;
        private System.Windows.Forms.TextBox CommentTxtBx;
        private FontAwesome.Sharp.IconButton NextBtn;
        private FontAwesome.Sharp.IconButton QuestionLbl;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton InterventionTxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton UploadImageBtn;
        private System.Windows.Forms.CheckBox checkBox;
        private FontAwesome.Sharp.IconButton CompletedTxt;
        private System.Windows.Forms.TextBox interventiontxtbx;
        private System.Windows.Forms.TextBox ActionTakenTxtBx;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton PreviousBtn;
        private FontAwesome.Sharp.IconButton CategoryLbl;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton SubmitBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label ActionsLbl;
        private System.Windows.Forms.Label CommentLbl;
        private System.Windows.Forms.DataGridView QuestionGrid;
    }
}