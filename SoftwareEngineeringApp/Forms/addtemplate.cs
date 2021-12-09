using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftwareEngineeringApp.Forms
{
    public partial class addtemplate : Form
    {
        public addtemplate()
        {
            InitializeComponent();
        }

        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\victo\source\repos\software application\SoftwareEngineeringApp\SoftwareEngineering.mdf;Integrated Security=True;Connect Timeout=30");

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SqlCommand sn = new SqlCommand("Insert into add values('" + textBox1.Text+"', '" + textBox4.Text+"', '" + textBox2.Text+"'," + textBox3.Text+" )", sc);

            sc.Open();

            sn.ExecuteNonQuery();

            sc.Close();

            MessageBox.Show("The data has been saved successfully!");
        }
         



        private void SelectTemplateLbl_Click(object sender, EventArgs e)
        {

        }


    
        

            

            

            

        

        private void Exitbtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addtemplate_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void QuestionsLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    } 
