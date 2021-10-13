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

namespace SoftwareEngineeringApp.Forms
{
    public partial class ListTemplatesForm : Form
    {
        public int template_no = 0;
        public ListTemplatesForm()
        {

            InitializeComponent();
        }

        private void ListTemplatesForm_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'software_EngineerDataSet2.Template'. È possibile spostarla o rimuoverla se necessario.
            this.templateTableAdapter.Fill(this.software_EngineerDataSet2.Template);
           // String mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //string sqlquery = "SELECT Template_name FROM Template";

            //SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
           // sqlconn.Open();
           // SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
           // DataTable dt = new DataTable();
          //  sdr.Fill(dt);
           // TemplatesGridView.DataSource = dt;
           // sqlconn.Close();


        }

        private void TemplatesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            CategoriesLbl.Visible = true;
            CategoriesGridView.Visible = true;
            int orderno = 0;
            Int32.TryParse(TemplatesGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), out orderno);
            template_no = orderno;


            CategoriesGridView.DataSource = GetCategories();
        }

        private DataTable GetCategories()
        {
            
            DataTable dtCategories = new DataTable();
            string connectionString = "Data Source=DESKTOP-J7QCD3H;Initial Catalog=Software_Engineer;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Category FROM Categories WHERE Template_ID = " + template_no + "",con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    dtCategories.Load(reader);
                }
            }
            return dtCategories;
           
        }
    }
}
