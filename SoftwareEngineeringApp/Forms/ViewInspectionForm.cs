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
    public partial class ViewInspectionForm : Form
    {
        
        int audit_ID;
        public ViewInspectionForm(int audit_no)
        {
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            InitializeComponent();
            fillGridView(audit_no);
            string auditsQuery = "select * from audit_info ";
            string[] Audits = dbConn.ReturnAllByColumnName("audit_Info", "Audit_ID", auditsQuery);
            FillCombo(Audits, AuditsCB);
            AuditsCB.Text = audit_no.ToString();

        }

        private void fillGridView(int ID)
        {
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetQuestions = dbConn.GetData("select a.question_ID, q.question, c.category from Audit a inner join categories c on a.category_ID = c.category_ID inner join questions q on a.question_ID = q.question_ID where Audit_ID= " + ID + "");
            QuestionGrid.DataSource = datasetQuestions.Tables[0];
        }

        private void QuestionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Category = (string)QuestionGrid.Rows[e.RowIndex].Cells[2].Value;
            string question = (string)QuestionGrid.Rows[e.RowIndex].Cells[1].Value;
            int questionID = (int)QuestionGrid.Rows[e.RowIndex].Cells[0].Value;

            string actionTaken = null;

            string query = ("SELECT Interventions, Completed, Action_Taken, Comment FROM audit WHERE audit_ID=@audit_ID and question_ID = @question_ID");
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataTable dataTableSite = dbConn.GetValueByID2(query, questionID, "question_ID", audit_ID, "audit_ID");

            if (dataTableSite.Rows.Count > 0)
            {
                DataRow row = dataTableSite.Rows[0];

              //  siteName = row["Site_Name"].ToString();
            }
          //  return siteName;



            QuestionLbl.Text = question;
            CategoryLbl.Text = Category;
            int isCompleted = Int32.Parse((string)dataTableSite.Rows[0][1]);
            //checkBox.CheckState = CheckState.Checked;
            //MessageBox.Show(isCompleted.ToString());
            if(isCompleted == 1)
            {
                checkBox.CheckState = CheckState.Checked;
            }
            else if(isCompleted == 0)
            {
                checkBox.CheckState = CheckState.Unchecked;
            }
          
            interventiontxtbx.Text = dataTableSite.Rows[0][0].ToString();
            ActionTakenTxtBx.Text = dataTableSite.Rows[0][2].ToString();
            CommentTxtBx.Text = dataTableSite.Rows[0][3].ToString();
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

        private void AuditsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            audit_ID = int.Parse(AuditsCB.Text);
            fillGridView(audit_ID);
            

        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            pdf.GetHeader(audit_ID);
        }
    }


}
