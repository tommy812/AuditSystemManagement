using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareEngineeringApp.Classes;

namespace SoftwareEngineeringApp
{
    public partial class LogInForm : Form
    {
        User user = new User();

        public string user_name;
        public static string user_surname;
        public static string user_role;
        public static Int32 user_site;
        
        

        public LogInForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            MainForm form2 = new MainForm();
            form2.Show();
            this.Visible = false;
        }

        private void LogInBtn_MouseHover(object sender, EventArgs e)
        {
            user.Email = UsernameTxtB.Text;
            user.Password = PasswordTxtB.Text;
            
            bool verify = user.User_verification();
            if(verify == true)
            {
    
                
                int role = user.Role;
                if (role == 0)
                {
                    user_role = "SuperUser";
                }
                else if (role == 1)
                {
                    user_role = "Manager";
                }
                else if (role == 2)
                {
                    user_role = "Supervisor";
                }
                else if (role == 3)
                {
                    user_role = "Inspector";
                }
                MessageBox.Show("Logged in as Name: "+user.Name+", Surname: "+user.Surname+", Role "+user_role+", SiteID "+user.Site);
                MainForm form2 = new MainForm();
                form2.Show();
                this.Visible = false;
                user_name = user.Name;
                user_surname = user.Surname;
                user_site = user.Site;
                
            }
            else
            {
                MessageBox.Show("Check your Credentials!", "Error");
            }
            
        }
    }
}
