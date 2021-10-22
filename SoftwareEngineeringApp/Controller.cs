using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringApp
{
    class Controller
    {
        public void openForm(Form ToOpenForm, Form ActiveForm, Panel MainPanel)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
                ActiveForm = ToOpenForm;
                ToOpenForm.TopLevel = false;
                ToOpenForm.FormBorderStyle = FormBorderStyle.None;
                ToOpenForm.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(ToOpenForm);
                MainPanel.Tag = ToOpenForm;
                ToOpenForm.BringToFront();
                ToOpenForm.Show();

        }
    }
}
