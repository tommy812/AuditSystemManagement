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
        public string userName;
        public string Site;
        public int template_no = 1;
        public ListTemplatesForm(string username, string site)
        {
            InitializeComponent();
            Site = site;
            userName = username;
            //Populate first gridview with the possible termplates
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetTemplates = dbConn.GetData("SELECT * FROM Template");
            TemplateGrid.DataSource = datasetTemplates.Tables[0];

        }

        //Open inspection form 
        private void iconButton1_Click(object sender, EventArgs e)
        {
            

            NewInspectionForm form2 = new NewInspectionForm(template_no, userName, Site);
            form2.Show();

        }

        //populate all gridview with the questions contained in a selected template.
        private void TemplateGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CategoriesLbl.Visible = true;
                QuestionsLbl.Visible = true;
                CategoryGrid.Visible = true;
                QuestionGrid.Visible = true;
                Int32.TryParse(TemplateGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out template_no);
                DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            
                DataSet datasetCategory = dbConn.GetData("select DISTINCT c.Category_ID, Category from Categories c  inner join Questions_Allocation cl  on c.Category_ID = cl.Category_ID where cl.Template_ID = " + template_no + " ORDER BY c.Category_ID ASC;");


                DataSet datasetQuestions = dbConn.GetData("SELECT DISTINCT q.Question, q.Category_ID FROM Questions q  inner join Questions_Allocation qa  on q.Category_ID = qa.Category_ID and qa.Template_ID = " + template_no + " ORDER BY q.Category_ID ASC;");

                CategoryGrid.DataSource = datasetCategory.Tables[0];
                QuestionGrid.DataSource = datasetQuestions.Tables[0];
            }
            catch (Exception)
            {

            }
        }

        //populate questions gridview when with only questions contained in the category selected
        private void CategoryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int categoryID;
            try
            {

                Int32.TryParse(CategoryGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out categoryID);

                DBConnection dbConn = DBConnection.getInstanceOfDBConnection();

                DataSet datasetQuestions = dbConn.GetData("SELECT DISTINCT q.Question, q.Category_ID FROM Questions q inner join Questions_Allocation qa  on q.Category_ID = " + categoryID + " and qa.Template_ID = " + template_no + " ORDER BY q.Category_ID ASC;");
                QuestionGrid.DataSource = datasetQuestions.Tables[0];
            }catch (Exception)
            {

            }

        }
    }
  
    
    
}