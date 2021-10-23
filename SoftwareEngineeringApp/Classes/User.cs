
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareEngineeringApp.Classes;
using System.Data.SqlClient;

namespace SoftwareEngineeringApp.Classes
{
    class User
    {
        public string Name { set; get;  }
        public string Surname { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public Int32 Role { set; get; }
        public Int32 Site { set; get; }
        public string SiteName { set; get; }

        public bool User_verification2()
        {
            bool exist;
            string query = ("SELECT * FROM Users WHERE Email =" + Email + " AND Password =" + Password + "");
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataTable dataTableUsers = dbConn.GetDataTable(query);
            if (dataTableUsers == null)
            {
                exist = false;
            }
            else
            {
                exist = true;
                foreach (DataRow dr in dataTableUsers.Rows)
                {
                    Role = dr.Field<int>("Role_ID");
                }
            }

            return exist;
        }
        public bool User_verification()
        {
            bool exist;
            string dBConnectionString = Properties.Settings.Default.DBConnectionString;
            SqlConnection con = new SqlConnection(dBConnectionString);

            SqlDataReader rd;
            exist = false;
            using (var cmd = new SqlCommand())
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM Users WHERE Email = @Email AND Password = @Pass";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Password;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Name = rd.GetString(rd.GetOrdinal("Name"));
                    Surname = rd.GetString(rd.GetOrdinal("Surname"));
                    Role = rd.GetInt32(rd.GetOrdinal("Role_ID"));
                    Site = rd.GetInt32(rd.GetOrdinal("Site_ID"));
                    
                }
                if (rd.HasRows)
                {
                    SiteName = getSiteName(Site);
                    exist = true;
                }
                    con.Close();
            }
           

            return exist;
        }

        public string getSiteName(int siteID)
        {
            string siteName = null;

            string query = ("SELECT Site_Name FROM Sites WHERE Site_ID=@Site_ID");
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataTable dataTableSite = dbConn.GetValueByID(query, siteID, "Site_ID");

            if (dataTableSite.Rows.Count > 0)
            {
                DataRow row = dataTableSite.Rows[0];

                siteName = row["Site_Name"].ToString();
            }
            return siteName;
        }

    }
}
