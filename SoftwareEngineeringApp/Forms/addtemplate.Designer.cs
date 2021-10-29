namespace SoftwareEngineeringApp.Forms
{
    partial class addtemplate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTemplateLbl = new System.Windows.Forms.Label();
            this.QuestionsLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.addquestion = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 140);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(400, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD TEMPLATE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectTemplateLbl
            // 
            this.SelectTemplateLbl.AutoSize = true;
            this.SelectTemplateLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTemplateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SelectTemplateLbl.Location = new System.Drawing.Point(31, 174);
            this.SelectTemplateLbl.Name = "SelectTemplateLbl";
            this.SelectTemplateLbl.Size = new System.Drawing.Size(231, 23);
            this.SelectTemplateLbl.TabIndex = 3;
            this.SelectTemplateLbl.Text = "Enter Name of Template";
            this.SelectTemplateLbl.Click += new System.EventHandler(this.SelectTemplateLbl_Click);
            // 
            // QuestionsLbl
            // 
            this.QuestionsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionsLbl.AutoSize = true;
            this.QuestionsLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.QuestionsLbl.Location = new System.Drawing.Point(495, 244);
            this.QuestionsLbl.Name = "QuestionsLbl";
            this.QuestionsLbl.Size = new System.Drawing.Size(104, 23);
            this.QuestionsLbl.TabIndex = 6;
            this.QuestionsLbl.Text = "Questions:";
            this.QuestionsLbl.Visible = false;
            this.QuestionsLbl.Click += new System.EventHandler(this.QuestionsLbl_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(242, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(628, 31);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "COMMENT";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(945, 445);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 14;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // addquestion
            // 
            this.addquestion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addquestion.Location = new System.Drawing.Point(864, 314);
            this.addquestion.Name = "addquestion";
            this.addquestion.Size = new System.Drawing.Size(156, 23);
            this.addquestion.TabIndex = 15;
            this.addquestion.Text = "+ Add Question";
            this.addquestion.UseVisualStyleBackColor = true;
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(864, 445);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 16;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // addtemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 645);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.addquestion);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QuestionsLbl);
            this.Controls.Add(this.SelectTemplateLbl);
            this.Controls.Add(this.panel1);
            this.Name = "addtemplate";
            this.Text = "addtemplate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectTemplateLbl;
        private System.Windows.Forms.Label QuestionsLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button addquestion;
        private System.Windows.Forms.Button savebtn;
    }
}