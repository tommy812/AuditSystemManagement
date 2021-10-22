using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareEngineeringApp.Classes;


namespace SoftwareEngineeringApp.Forms
{
    public partial class ListTemplatesForm : Form
    {
        public int template_no = 0;
        public ListTemplatesForm()
        {
            InitializeComponent();
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetTemplates = dbConn.GetData("SELECT * FROM Template");
            TemplateGrid.DataSource = datasetTemplates.Tables[0];
        }

       // DataSet datasetTemplates = dbConn.GetData("SELECT Category FROM Categories WHERE Template_ID = " + template_no + "")

               // using (SqlCommand cmd = new SqlCommand("SELECT Category FROM Categories WHERE Template_ID = " + template_no + "",con))


        //   using (SqlCommand cmd = new SqlCommand("SELECT Question, Category_ID FROM Questions WHERE Template_ID = " + template_no + "", con))

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();

            InspectionForm form2 = new InspectionForm();
            form2.Show();

        }


        private void TemplateGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriesLbl.Visible = true;
            QuestionsLbl.Visible = true;
            CategoryGrid.Visible = true;
            QuestionGrid.Visible = true;
            Int32.TryParse(TemplateGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out template_no);
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetCategory = dbConn.GetData("SELECT Category FROM Categories WHERE Template_ID = " + template_no + "");
            DataSet datasetQuestions = dbConn.GetData("SELECT Question, Category_ID FROM Questions WHERE Template_ID = " + template_no + "");
            CategoryGrid.DataSource = datasetCategory.Tables[0];
            QuestionGrid.DataSource = datasetQuestions.Tables[0];

        }
    }
}
