using SoftwareEngineeringApp.Classes;
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
    public partial class Dashboard : Form
    {
        string user;
        DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
        public Dashboard(string Username)
        {
            user = Username;
            InitializeComponent();
            
            DataSet datasetAudits = dbConn.GetData("Select a.Audit_ID, a.Date, a.Completed_By, s.Site_Name, w.Area, u.Name, t.type, te.template_name, i.Interventions From audit_info a inner join Sites s on a.Site_ID = s.Site_ID inner join work_area w on a.Area_ID = w.Work_area_ID inner join users u on a.Inspector_ID = u.User_ID inner join Inspection_type t on a.Type_ID = t.type_ID inner join Template te on a.template_ID = te.template_ID inner join audit_Overall_result i on a.audit_ID = i.audit_ID");
            // DataSet datasetTemplates = dbConn.GetData("select audit.audit_ID, audit.date, audit.completed_by, audit.site_ID, audit.area_ID, audit.supervisor_ID, audit.ispector_ID, audit.type_ID, audit.template_ID FROM site INNER JOIN audit.site_ID ON  = audit.site_ID INNER JOIN audit.area_ID ON = audit.area_ID INNER JOIN audit.inspector_ID ON = audit.inspector_ID INNER JOIN audit.type_ID ON = audit.type_ID INNER JOIN audit.template_ID ON = audit.template_ID ORDER BY audit_ID ASC");
            ListGridView.DataSource = datasetAudits.Tables[0];

            int number = dbConn.CountElements("audit_Info");
            nReports.Text = "Total Reports: " + number;

            string siteQuery = "select * from Sites";
            string[] Sites = dbConn.ReturnAllByColumnName("Sites", "Site_Name", siteQuery);
            FillCombo(Sites, sitesCB);
        }

        private void ListGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int audit_no;
                Int32.TryParse(ListGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), out audit_no);
                ViewInspectionForm form2 = new ViewInspectionForm(audit_no);
                form2.Show();
            }
            catch (Exception)
            {

            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            //chart1.Series[0].XValueMember = "Interventions";
           // chart1.Series[0].YValueMembers = "Interventions";

            //chart1.Series[1].XValueMember = "Inspections";
            //chart1.Series[1].YValueMembers = "Inspections";

          
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ChartLoad();

        }

        private void ChartLoad()
        {
            
            var query = "select sum(r.interventions) as 'Intervents', count(a.audit_ID) as 'Inspections', s.Site_Name as 'Site' from audit_overall_result r inner join Audit_info a on r.audit_ID = a.audit_Id inner join sites s on s.site_ID = a.site_ID group by s.Site_Name";
            DataTable stats = dbConn.GetDataTable(query);
            //chart1.DataSource = stats;
            //chart1.Series["Series1"].XValueMember = "Site";
            //chart1.Series["Series1"].YValueMembers = "Inspections";

            chart1.DataBindCrossTable(stats.DefaultView, "Site", "Inspections", "Intervents", "");

        }


        private void fill_Grid()
        {
            DataSet datasetAudits = dbConn.GetData("Select a.Audit_ID, a.Date, a.Completed_By, s.Site_Name, w.Area, u.Name, t.type, te.template_name, i.Interventions From audit_info a inner join Sites s on a.Site_ID = s.Site_ID inner join work_area w on a.Area_ID = w.Work_area_ID inner join users u on a.Inspector_ID = u.User_ID inner join Inspection_type t on a.Type_ID = t.type_ID inner join Template te on a.template_ID = te.template_ID inner join audit_Overall_result i on a.audit_ID = i.audit_ID");
            ListGridView.DataSource = datasetAudits.Tables[0];
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet datasetAudits = dbConn.GetData("Select a.Audit_ID, a.Date, a.Completed_By, s.Site_Name, w.Area, u.Name, t.type, te.template_name, i.Interventions From audit_info a inner join Sites s on a.Site_ID = s.Site_ID inner join work_area w on a.Area_ID = w.Work_area_ID inner join users u on a.Inspector_ID = u.User_ID inner join Inspection_type t on a.Type_ID = t.type_ID inner join Template te on a.template_ID = te.template_ID inner join audit_Overall_result i on a.audit_ID = i.audit_ID");
            datasetAudits.Tables[0].DefaultView.RowFilter = "Site_Name = '"+sitesCB.Text+"'";
            DataTable dt = (datasetAudits.Tables[0].DefaultView).ToTable();
            ListGridView.DataSource = datasetAudits.Tables[0];
           
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

        private void sitesCB_TextChanged(object sender, EventArgs e)
        {
            if (sitesCB.Text == "")
            {
                fill_Grid();
            }
        }

        private void tenBtn_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataTable hdt = dbConn.GetData2("Select top 10 a.Audit_ID, a.Date, a.Completed_By, s.Site_Name, w.Area, u.Name, u.Name, t.type, te.template_name, i.Interventions From audit_info a inner join Sites s on a.Site_ID = s.Site_ID inner join work_area w on a.Area_ID = w.Work_area_ID inner join users u on a.Supervisor_ID = u.User_ID and a.Inspector_ID = u.User_ID inner join Inspection_type t on a.Type_ID = t.type_ID inner join Template te on a.template_ID = te.template_ID inner join audit_Overall_result i on a.audit_ID = i.audit_ID order by s.site_Name");
            pdf.exportListPdf(user,chart1 ,hdt, "10" );
        }

        private void hundredBtn_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataTable hdt = dbConn.GetData2("Select top 100 a.Audit_ID, a.Date, a.Completed_By, s.Site_Name, w.Area, u.Name, u.Name, t.type, te.template_name, i.Interventions From audit_info a inner join Sites s on a.Site_ID = s.Site_ID inner join work_area w on a.Area_ID = w.Work_area_ID inner join users u on a.Supervisor_ID = u.User_ID and a.Inspector_ID = u.User_ID inner join Inspection_type t on a.Type_ID = t.type_ID inner join Template te on a.template_ID = te.template_ID inner join audit_Overall_result i on a.audit_ID = i.audit_ID order by s.site_Name");
            pdf.exportListPdf(user, chart1, hdt, "100");
        }

        private void allbtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("List of all reports will be downloaded, the file may be very heavy and could take several minutes to download", "Do You Whish to continue?", MessageBoxButtons.OKCancel);
            switch (dr)
            {
                case DialogResult.OK:
                        PDF pdf = new PDF();
                        DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
                        DataTable hdt = dbConn.GetData2("Select a.Audit_ID, a.Date, a.Completed_By, s.Site_Name, w.Area, u.Name, u.Name, t.type, te.template_name, i.Interventions From audit_info a inner join Sites s on a.Site_ID = s.Site_ID inner join work_area w on a.Area_ID = w.Work_area_ID inner join users u on a.Supervisor_ID = u.User_ID and a.Inspector_ID = u.User_ID inner join Inspection_type t on a.Type_ID = t.type_ID inner join Template te on a.template_ID = te.template_ID inner join audit_Overall_result i on a.audit_ID = i.audit_ID order by s.site_Name");
                        pdf.exportListPdf(user, chart1, hdt, "All");
                    break;
                case DialogResult.Cancel:
                    break;
            }
            
        }
    }
}
