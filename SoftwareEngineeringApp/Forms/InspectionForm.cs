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
    public partial class InspectionForm : Form
    {


        string Category;
        string question;
        List<QuestionAns> QAnswer = new List<QuestionAns>(); 


        public InspectionForm(int templateId, int auditID, DateTime Date, string type, string supervisor, string inspector, string site, string workArea, string jobDescription)
        {
            InitializeComponent();
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();

            DataSet datasetQuestions = dbConn.GetData("select q.Question_ID, q.Question, c.Category from Questions q inner join Questions_Allocation qa  on q.Category_ID = qa.Category_ID inner join Categories c on q.Category_ID = c.Category_ID where qa.Template_ID = " + templateId + " ORDER BY q.Category_ID ASC;");
            QuestionGrid.DataSource = datasetQuestions.Tables[0];
            Category = (string)QuestionGrid.Rows[1].Cells[2].Value;
            question = (string)QuestionGrid.Rows[1].Cells[1].Value;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            PreviousBtn.Visible = true;
            int questionID = (int)QuestionGrid.Rows[1].Cells[0].Value;

            int interventionNo = int.Parse(interventiontxtbx.Text);
            bool completed = checkBox.Checked;
            string action = ActionTakenTxtBx.Text;
            string comments = CommentTxtBx.Text;

            saveQuestion(questionID,interventionNo, completed, action, comments); 


        }

        private void ActionTakenTxtBx_Click(object sender, EventArgs e)
        {
            ActionTakenTxtBx.SelectAll();
        }

        private void CommentTxtBx_Click(object sender, EventArgs e)
        {
            CommentTxtBx.SelectAll();
        }

        private void QuestionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            string Category = (string)QuestionGrid.Rows[e.RowIndex].Cells[2].Value;
            string question = (string)QuestionGrid.Rows[e.RowIndex].Cells[1].Value;
            QuestionLbl.Text = question;
            CategoryLbl.Text = Category;
        }

        private void saveQuestion(int Id, int interventions, bool Completed, string Action, string Comment)
        {
            QAnswer.Add(new QuestionAns
            {
                QuestionId = Id,
                Intervention_no = interventions,
                IsCompleted = Completed,
                ActionTaken = Action,
                Comments = Comment

            });

        }
        private void RetrieveQuestion(int QuestionID)
        {

        }
    }
}
