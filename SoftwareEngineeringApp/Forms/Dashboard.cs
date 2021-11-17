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
        public Dashboard()
        {
            InitializeComponent();
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetAudits = dbConn.GetData("Select a.Audit_ID, a.Date, a.Completed_By, s.Site_Name, w.Area, u.Name, t.type, te.template_name, i.Interventions From audit_info a inner join Sites s on a.Site_ID = s.Site_ID inner join work_area w on a.Area_ID = w.Work_area_ID inner join users u on a.Inspector_ID = u.User_ID inner join Inspection_type t on a.Type_ID = t.type_ID inner join Template te on a.template_ID = te.template_ID inner join audit_Overall_result i on a.audit_ID = i.audit_ID");
            // DataSet datasetTemplates = dbConn.GetData("select audit.audit_ID, audit.date, audit.completed_by, audit.site_ID, audit.area_ID, audit.supervisor_ID, audit.ispector_ID, audit.type_ID, audit.template_ID FROM site INNER JOIN audit.site_ID ON  = audit.site_ID INNER JOIN audit.area_ID ON = audit.area_ID INNER JOIN audit.inspector_ID ON = audit.inspector_ID INNER JOIN audit.type_ID ON = audit.type_ID INNER JOIN audit.template_ID ON = audit.template_ID ORDER BY audit_ID ASC");
            ListGridView.DataSource = datasetAudits.Tables[0];

            int number = dbConn.CountElements("audit_Info");
            nReports.Text = "Total Reports: " + number;
        }

        private void ListGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int audit_no;
            Int32.TryParse(ListGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), out audit_no);
            ViewInspectionForm form2 = new ViewInspectionForm(audit_no);
            form2.Show();
        }
    }
}
