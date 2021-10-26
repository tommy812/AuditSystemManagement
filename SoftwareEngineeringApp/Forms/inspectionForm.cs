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
    public partial class InspectionForm : Form
    {
        public InspectionForm(int templateId, int auditID, DateTime Date, string type, string supervisor, string inspector, string site, string workArea, string jobDescription)
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            PreviousBtn.Visible = true;
        }
    }
}
