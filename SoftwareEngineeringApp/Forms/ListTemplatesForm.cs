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



               // using (SqlCommand cmd = new SqlCommand("SELECT Category FROM Categories WHERE Template_ID = " + template_no + "",con))
               
       
             //   using (SqlCommand cmd = new SqlCommand("SELECT Question, Category_ID FROM Questions WHERE Template_ID = " + template_no + "", con))
   
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();

            InspectionForm form2 = new InspectionForm();
            form2.Show();

        }
    }
}
