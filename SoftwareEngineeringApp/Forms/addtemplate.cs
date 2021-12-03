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
    public partial class addtemplate : Form
    {
        public addtemplate()
        {
            InitializeComponent();
        }

        private void SelectTemplateLbl_Click(object sender, EventArgs e)
        {

        }


    
        private void Savebtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to save this template?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string templateName = textBox2.Text;
            string category = textBox3.Text;
            string answer = textBox1.Text;
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";
            Savebtn_Click();
        }

        //where I want the  created template to be saved
        public void Savebtn_Click()
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to save this template?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string templateName= textBox2.Text;
            string category = textBox3.Text;
            string answer = textBox1.Text;
            string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";

         }

            

            private void Nextbtn(object sender, EventArgs e)
            {

            }

            

        

        private void Exitbtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addtemplate_Load(object sender, EventArgs e)
        {

        }
    }
    } 
