namespace SoftwareEngineeringApp.Forms
{
    partial class MenageUsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.UserGridV = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.siteTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1445, 166);
            this.panel2.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(373, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(747, 57);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add, Remove and Search Data";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(1341, 204);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 50);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_Search.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Search.Location = new System.Drawing.Point(1063, 428);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(155, 50);
            this.btn_Search.TabIndex = 36;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_Del.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Del.Location = new System.Drawing.Point(1063, 354);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(155, 50);
            this.btn_Del.TabIndex = 35;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_Update.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Update.Location = new System.Drawing.Point(1063, 284);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(155, 50);
            this.btn_Update.TabIndex = 34;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnInsert.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInsert.Location = new System.Drawing.Point(1063, 204);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(155, 50);
            this.btnInsert.TabIndex = 33;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click_1);
            // 
            // UserGridV
            // 
            this.UserGridV.AllowUserToAddRows = false;
            this.UserGridV.AllowUserToDeleteRows = false;
            this.UserGridV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserGridV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.UserGridV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserGridV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGridV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UserGridV.ColumnHeadersHeight = 30;
            this.UserGridV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UserGridV.EnableHeadersVisualStyles = false;
            this.UserGridV.GridColor = System.Drawing.Color.SteelBlue;
            this.UserGridV.Location = new System.Drawing.Point(160, 567);
            this.UserGridV.Margin = new System.Windows.Forms.Padding(4);
            this.UserGridV.Name = "UserGridV";
            this.UserGridV.ReadOnly = true;
            this.UserGridV.RowHeadersVisible = false;
            this.UserGridV.RowHeadersWidth = 51;
            this.UserGridV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.UserGridV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.UserGridV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGridV.Size = new System.Drawing.Size(1076, 311);
            this.UserGridV.TabIndex = 83;
            this.UserGridV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGridV_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(188, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 30);
            this.label8.TabIndex = 82;
            this.label8.Text = "Role ID";
            // 
            // roleTxt
            // 
            this.roleTxt.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.roleTxt.Location = new System.Drawing.Point(332, 425);
            this.roleTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(123, 36);
            this.roleTxt.TabIndex = 81;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.emailTxt.Location = new System.Drawing.Point(332, 377);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(535, 36);
            this.emailTxt.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(187, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 30);
            this.label7.TabIndex = 79;
            this.label7.Text = "Email";
            // 
            // surnameTxt
            // 
            this.surnameTxt.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.surnameTxt.Location = new System.Drawing.Point(332, 325);
            this.surnameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(535, 36);
            this.surnameTxt.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(187, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 30);
            this.label6.TabIndex = 77;
            this.label6.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(188, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 30);
            this.label5.TabIndex = 76;
            this.label5.Text = "User ID";
            // 
            // siteTxt
            // 
            this.siteTxt.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.siteTxt.Location = new System.Drawing.Point(332, 473);
            this.siteTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siteTxt.Name = "siteTxt";
            this.siteTxt.Size = new System.Drawing.Size(123, 36);
            this.siteTxt.TabIndex = 75;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.nameTxt.Location = new System.Drawing.Point(332, 271);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(535, 36);
            this.nameTxt.TabIndex = 74;
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.userTxt.Location = new System.Drawing.Point(332, 213);
            this.userTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(123, 36);
            this.userTxt.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(188, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 30);
            this.label3.TabIndex = 72;
            this.label3.Text = "Site ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(187, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 71;
            this.label2.Text = "Name";
            // 
            // MenageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1445, 967);
            this.Controls.Add(this.UserGridV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.roleTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.siteTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btnInsert);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenageUsersForm";
            this.Text = "MenageUsersForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView UserGridV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox siteTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}