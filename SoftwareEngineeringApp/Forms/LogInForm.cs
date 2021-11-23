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
        private static Int32 user_site;
        public static string site_name;

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
            user.Email = UsernameTxtB.Text;
            user.Password = PasswordTxtB.Text;

            bool verify = user.User_verification();
            if (verify == true)
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
                site_name = user.SiteName;
                MessageBox.Show("Logged in as: "+Environment.NewLine+" Name: " + user.Name + ", Surname: " + user.Surname + ", Role: " + user_role + ", Site: " + site_name);

                
                MainForm form2 = new MainForm(user.Name, user.Surname, user_role, site_name);
                form2.Show();
                this.Visible = false;


            }
            else
            {
                MessageBox.Show("Check your Credentials!", "Error");
            }
        }
    }
}
