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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Activate Student Form Function
        private Form ActiveForm = null;

        //openform
        private void openForm(Form ToOpenForm)
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
            openForm(new ListTemplatesForm());
        }
    }

    
}

