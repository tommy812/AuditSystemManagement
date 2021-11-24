using SoftwareEngineeringApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareEngineeringApp;
using SoftwareEngineeringApp.Classes;



namespace SoftwareEngineeringApp
{
    public partial class MainForm : Form
    {
        string username;
        string Site;


        public MainForm(string name, string surname, string role, string site )
        {
            
            //MessageBox.Show(name);
            InitializeComponent();
            timer1.Start();
            username = name + " " + surname;
            Site = site;
            UsernameBtn.Text = "User: "+ username;

            LocationBtn.Text = "Site: " + site;
            if (role == "SuperUser" || role == "Manager")
            {
                AddTemplateBtn.Visible = true;
                AdminDashboardBtn.Visible = true;
            }
            
        }



        //Activate Student Form Function
         private Form ActiveForm = null;
        
       
       
        //openform
        public void openForm(Form ToOpenForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
                ActiveForm = ToOpenForm;
                ToOpenForm.TopLevel = false;
                ToOpenForm.FormBorderStyle = FormBorderStyle.None;
                ToOpenForm.Dock = DockStyle.Fill;
                DefaultLogoPnl.Controls.Add(ToOpenForm);
                DefaultLogoPnl.Tag = ToOpenForm;
                ToOpenForm.BringToFront();
                ToOpenForm.Show();

        }

        private void NewInspectionBtn_Click(object sender, EventArgs e)
        {
            openForm(new ListTemplatesForm(username, Site));
       
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeBtn.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            
            LogInForm form1 = new LogInForm();
            form1.Show();
            this.Visible = false;

        }

        private void AddTemplateBtn_Click(object sender, EventArgs e)
        {
            openForm(new addtemplate());
        }

        private void AdminDashboardBtn_Click(object sender, EventArgs e)
        {
            openForm(new Dashboard(username));
        }
    }

    
}

