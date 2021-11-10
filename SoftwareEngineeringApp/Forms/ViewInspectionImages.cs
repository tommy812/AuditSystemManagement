using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringApp.Forms
{
    public partial class viewInspectionImages : Form
    {
        public viewInspectionImages()
        {
            InitializeComponent();
        }

        private void lblViewImage_Click(object sender, EventArgs e)
        {
            lblViewImage.Text = "Click to view images from inspection";
        }
    }
}
