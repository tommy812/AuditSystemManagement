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

namespace SoftwareEngineeringApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void Working_stand_Click(object sender, EventArgs e)
        {

        }

        // Thomas made this button to develope a new form 
        //Do not delete the button code Please :)
        private void MenageUsersBtn_Click(object sender, EventArgs e)
        {
            MenageUsersForm form2 = new MenageUsersForm();
            form2.Show();
        }
    }
}
