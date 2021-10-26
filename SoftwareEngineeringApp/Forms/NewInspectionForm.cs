using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareEngineeringApp.Classes;

namespace SoftwareEngineeringApp.Forms
{
    public partial class NewInspectionForm : Form
    {
        
        public NewInspectionForm(int template_no)
        {
            string workAreaQuery = "select * from Work_Area";
            string supervisorQuery = "select * from Users "; 
            InitializeComponent();
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            int auditID = dbConn.CountElements("Audit_info");
            auditID++;

            AuditIDTxt.Text = auditID.ToString();
            DateTxt.Text = DateTime.Now.ToLongDateString();
            string[] WorkArea = dbConn.ReturnAllByColumnName("Work_Area","Area", workAreaQuery);
            string[] Supervisors = dbConn.ReturnAllByColumnName("Users","Name", supervisorQuery);
            FillCombo(WorkArea, WorkAreaCB);
            FillCombo(Supervisors, SupervisorCB);
            //MessageBox.Show(WorkArea[1]);
        
        }

        public void FillCombo(Array array, ComboBox c)
        {
            if (array != null)
            {
                foreach (var a in array)
                {
                    c.Items.Add(a);
                }
            }
         
        }


    }
}
