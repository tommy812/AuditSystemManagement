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

            //Populate first gridview with the possible termplates
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetTemplates = dbConn.GetData("SELECT * FROM Template");
            TemplateGrid.DataSource = datasetTemplates.Tables[0];
        }

        //Open inspection form 
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();

            InspectionForm form2 = new InspectionForm();
            form2.Show();

        }

        //populate all gridview with the questions contained in a selected template.
        private void TemplateGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriesLbl.Visible = true;
            QuestionsLbl.Visible = true;
            CategoryGrid.Visible = true;
            QuestionGrid.Visible = true;
            Int32.TryParse(TemplateGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out template_no);
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
           // DataSet datasetCategory = dbConn.GetData("SELECT Category FROM Categories WHERE Template_ID = " + template_no + "");
            DataSet datasetCategory = dbConn.GetData("select DISTINCT c.Category_ID, Category from Categories c  inner join Questions cl  on c.Category_ID = cl.Category_ID where cl.Template_ID = " + template_no + " ORDER BY c.Category_ID ASC;");
            DataSet datasetQuestions = dbConn.GetData("SELECT Question, Category_ID FROM Questions WHERE Template_ID = " + template_no + " ORDER BY Category_ID ASC;");
            CategoryGrid.DataSource = datasetCategory.Tables[0];
            QuestionGrid.DataSource = datasetQuestions.Tables[0];

        }
    }
  
    
    
}