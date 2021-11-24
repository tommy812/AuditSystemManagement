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
    public partial class MenageUsersForm : Form
    {
        public MenageUsersForm()
        {
            InitializeComponent();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\inahi\source\repos\SoftwareEngineeringApp\newSE\SoftwareEngineeringApp\SoftwareEngineering.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Users values (@User_ID,@Name,@Site_ID)", con);
            cmd.Parameters.AddWithValue("@User_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Site_ID", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved!");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\inahi\source\repos\SoftwareEngineeringApp\newSE\SoftwareEngineeringApp\SoftwareEngineering.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Users set Name=@Name, User_ID=@User_ID, Site_ID=@Site_ID", con);
            cmd.Parameters.AddWithValue("@User_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Site_ID", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated!");
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\inahi\source\repos\SoftwareEngineeringApp\newSE\SoftwareEngineeringApp\SoftwareEngineering.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Users where User_ID=@User_ID", con);
            cmd.Parameters.AddWithValue("@User_ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Deleted!");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\inahi\source\repos\SoftwareEngineeringApp\newSE\SoftwareEngineeringApp\SoftwareEngineering.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Users where User_ID=@User_ID", con);
            cmd.Parameters.AddWithValue("User_ID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
