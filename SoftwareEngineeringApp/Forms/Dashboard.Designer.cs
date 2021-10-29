namespace SoftwareEngineeringApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.working_stand = new System.Windows.Forms.Button();
            this.quality = new System.Windows.Forms.Button();
            this.site_rules = new System.Windows.Forms.Button();
            this.environmental = new System.Windows.Forms.Button();
            this.protection_indiv = new System.Windows.Forms.Button();
            this.equipments = new System.Windows.Forms.Button();
            this.miscellaneous = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(920, 140);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(341, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // working_stand
            // 
            this.working_stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.working_stand.Location = new System.Drawing.Point(89, 182);
            this.working_stand.Name = "working_stand";
            this.working_stand.Size = new System.Drawing.Size(141, 63);
            this.working_stand.TabIndex = 4;
            this.working_stand.Text = "Working Standards";
            this.working_stand.UseVisualStyleBackColor = true;
            this.working_stand.Click += new System.EventHandler(this.Working_stand_Click);
            // 
            // quality
            // 
            this.quality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quality.Location = new System.Drawing.Point(89, 265);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(141, 54);
            this.quality.TabIndex = 5;
            this.quality.Text = "Quality";
            this.quality.UseVisualStyleBackColor = true;
            // 
            // site_rules
            // 
            this.site_rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.site_rules.Location = new System.Drawing.Point(89, 345);
            this.site_rules.Name = "site_rules";
            this.site_rules.Size = new System.Drawing.Size(141, 54);
            this.site_rules.TabIndex = 6;
            this.site_rules.Text = "Site Rules";
            this.site_rules.UseVisualStyleBackColor = true;
            // 
            // environmental
            // 
            this.environmental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.environmental.Location = new System.Drawing.Point(89, 425);
            this.environmental.Name = "environmental";
            this.environmental.Size = new System.Drawing.Size(141, 54);
            this.environmental.TabIndex = 7;
            this.environmental.Text = "Environmental";
            this.environmental.UseVisualStyleBackColor = true;
            // 
            // protection_indiv
            // 
            this.protection_indiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.protection_indiv.Location = new System.Drawing.Point(318, 182);
            this.protection_indiv.Name = "protection_indiv";
            this.protection_indiv.Size = new System.Drawing.Size(141, 63);
            this.protection_indiv.TabIndex = 8;
            this.protection_indiv.Text = "Protection Of Individuals";
            this.protection_indiv.UseVisualStyleBackColor = true;
            // 
            // equipments
            // 
            this.equipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipments.Location = new System.Drawing.Point(318, 265);
            this.equipments.Name = "equipments";
            this.equipments.Size = new System.Drawing.Size(141, 54);
            this.equipments.TabIndex = 9;
            this.equipments.Text = "Tools, Cables & other Equipment";
            this.equipments.UseVisualStyleBackColor = true;
            // 
            // miscellaneous
            // 
            this.miscellaneous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscellaneous.Location = new System.Drawing.Point(318, 345);
            this.miscellaneous.Name = "miscellaneous";
            this.miscellaneous.Size = new System.Drawing.Size(141, 54);
            this.miscellaneous.TabIndex = 10;
            this.miscellaneous.Text = "Miscellaneous";
            this.miscellaneous.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(589, 425);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(83, 28);
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(701, 425);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(69, 27);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(701, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(637, 212);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 14;
            this.Total.Text = "Total";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 521);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.miscellaneous);
            this.Controls.Add(this.equipments);
            this.Controls.Add(this.protection_indiv);
            this.Controls.Add(this.environmental);
            this.Controls.Add(this.site_rules);
            this.Controls.Add(this.quality);
            this.Controls.Add(this.working_stand);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button working_stand;
        private System.Windows.Forms.Button quality;
        private System.Windows.Forms.Button site_rules;
        private System.Windows.Forms.Button environmental;
        private System.Windows.Forms.Button protection_indiv;
        private System.Windows.Forms.Button equipments;
        private System.Windows.Forms.Button miscellaneous;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Total;
    }
}

