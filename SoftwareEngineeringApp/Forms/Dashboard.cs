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
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetTemplates = dbConn.GetData("select audit.audit_ID, audit.date, audit.completed_by, audit.site_ID, audit.area_ID, audit.supervisor_ID, audit.ispector_ID, audit.type_ID, audit.template_ID FROM audit INNER JOIN  ON  = audit.id INNER JOIN ON call.call_outcome_id = call_outcome.id ORDER BY call.start_time ASC");

        }

        
        private void Label1_Click(object sender, EventArgs e)
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

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
