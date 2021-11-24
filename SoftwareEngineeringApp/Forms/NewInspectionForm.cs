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
        
        public NewInspectionForm(int template_no, string username, string site)
        {
            string workAreaQuery = "select * from Work_Area";
            string supervisorQuery = "select * from Users "; 
            InitializeComponent();
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            int auditID = dbConn.CountElements("Audit_info");
            auditID++;

            AuditIDTxt.Text = auditID.ToString();
            TemplateNoTxt.Text = template_no.ToString();
            InspectorTxt.Text = username.ToString();
            SiteTxt.Text = site.ToString();

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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (TypeTxt.Text == "")
            {
                MessageBox.Show("Insert Job Type.", "Field Missing");
            }
            else if (SupervisorCB.Text == "Please Select.")
            {
                MessageBox.Show("Select a SuperVisor.", "Field Missing");
            }
            else if (WorkAreaCB.Text == "Please Select.")
            {
                MessageBox.Show("Select a Work Area.", "Field Missing");
            }
            else if (DescriptionTxt.Text == "")
            {
                MessageBox.Show("Insert a job Description.", "Field Missing");
            }
            //else { 

                InspectionForm form2 = new InspectionForm(Int32.Parse(TemplateNoTxt.Text), Int32.Parse(AuditIDTxt.Text), DateTime.Parse(DateTxt.Text), TypeTxt.Text, SupervisorCB.Text, InspectorTxt.Text, SiteTxt.Text, WorkAreaCB.Text, DescriptionTxt.Text);
                form2.Show();
                this.Close();
            //}
        }
    }
}

// select count(r.interventions) as 'Interventions', count(a.audit_ID) as 'Inspections' s.Site_Name as 'Site' from audit_overall_result r inner join Audits_info a on r.audit_ID = a.audit_Id inner join sites s on s.site_ID = a.site_ID  group by s.site_ID