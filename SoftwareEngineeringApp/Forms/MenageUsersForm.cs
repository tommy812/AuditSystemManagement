using SoftwareEngineeringApp.Classes;
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
        DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
        int userID;
        string name;
        string surname;
        string email;
        int roleID;
        int siteID;
        public MenageUsersForm()
        {
            InitializeComponent();
            FillGrid();
        }
       

        private void UserGridV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //Int32.TryParse(UserGridV.Rows[e.RowIndex].Cells[0].Value.ToString(), out userID);
            name = UserGridV.Rows[e.RowIndex].Cells[1].Value.ToString();
            surname = UserGridV.Rows[e.RowIndex].Cells[2].Value.ToString();
            email = UserGridV.Rows[e.RowIndex].Cells[3].Value.ToString();
            Int32.TryParse(UserGridV.Rows[e.RowIndex].Cells[4].Value.ToString(), out roleID);
            Int32.TryParse(UserGridV.Rows[e.RowIndex].Cells[5].Value.ToString(), out siteID);
            userTxt.Text = userID.ToString();
            nameTxt.Text = name;
            surnameTxt.Text = surname;
            emailTxt.Text = email;
            roleTxt.Text = roleID.ToString();
            siteTxt.Text = siteID.ToString();

        }
        private void FillGrid()
        {
            DataSet UsersSet = dbConn.GetData("SELECT * FROM Users");
            UserGridV.DataSource = UsersSet.Tables[0];
        }

        private void BtnInsert_Click_1(object sender, EventArgs e)
        {
            name = nameTxt.Text;
            surname = surnameTxt.Text;
            email = emailTxt.Text;
            roleID = Int32.Parse(roleTxt.Text);
            siteID = Int32.Parse(siteTxt.Text);
            int id = dbConn.CountElements("Users");
            id++;
            userID = id;
            dbConn.InsertUser(userID, name, surname, email, roleID, siteID);
            FillGrid();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            userID = Int32.Parse(userTxt.Text);
            string query = ("Select * from Users where User_ID=@User_ID");
            DataTable dt = dbConn.GetValueByID(query, userID, "User_ID");
            UserGridV.DataSource = dt;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            name = nameTxt.Text;
            surname = surnameTxt.Text;
            email = emailTxt.Text;
            roleID = Int32.Parse(roleTxt.Text);
            siteID = Int32.Parse(siteTxt.Text);
            int id = dbConn.CountElements("Users");
            id++;
            userID = id;
            dbConn.UpdateUser(userID, name, surname, email, roleID, siteID);
            FillGrid();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            int id = dbConn.CountElements("Users");
            userID = id;
            dbConn.DeleteUser(userID);
            FillGrid();
        }
    }
}
