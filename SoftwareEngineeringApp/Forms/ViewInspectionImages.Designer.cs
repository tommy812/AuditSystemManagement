
namespace SoftwareEngineeringApp.Forms
{
    partial class viewInspectionImages
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
            this.btnViewImages = new System.Windows.Forms.Button();
            this.lblViewImage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewImages
            // 
            this.btnViewImages.Location = new System.Drawing.Point(61, 33);
            this.btnViewImages.Name = "btnViewImages";
            this.btnViewImages.Size = new System.Drawing.Size(432, 86);
            this.btnViewImages.TabIndex = 0;
            this.btnViewImages.Text = "View images from inspection";
            this.btnViewImages.UseVisualStyleBackColor = true;
            // 
            // lblViewImage
            // 
            this.lblViewImage.AutoSize = true;
            this.lblViewImage.Location = new System.Drawing.Point(244, 87);
            this.lblViewImage.Name = "lblViewImage";
            this.lblViewImage.Size = new System.Drawing.Size(99, 20);
            this.lblViewImage.TabIndex = 1;
            this.lblViewImage.Text = "ViewImages";
            this.lblViewImage.Click += new System.EventHandler(this.lblViewImage_Click);
            // 
            // viewInspectionImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblViewImage);
            this.Controls.Add(this.btnViewImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "viewInspectionImages";
            this.Text = "ViewInspectionImages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewImages;
        private System.Windows.Forms.Label lblViewImage;
    }
}