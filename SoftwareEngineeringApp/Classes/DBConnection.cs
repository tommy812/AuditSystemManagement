using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringApp.Classes
{
    class DBConnection
    {

        //attributes
        //private object of the class itself 
        private static DBConnection _instance;
        private static string dBConnectionString;

        //Constructor 
        private DBConnection()
        {
            //initialise the DBconnection string 
            dBConnectionString = Properties.Settings.Default.DBConnectionString;
        }

        //methods
        //static method that gives access to thte private object 

        public static DBConnection getInstanceOfDBConnection()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public static SqlConnection connect() 
        {
            SqlConnection connToDB = new SqlConnection(dBConnectionString);
            return connToDB;
        }

        //returns dataset
        public DataSet GetData(string sqlQuery)
        {

            DataSet dataset = new DataSet();

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                //open connection
                connToDB.Open();

                //send  sql  query to the database
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);

                //filll in the dataset
                adapter.Fill(dataset);

            }


                return dataset;
        }

        //returns datatable
        public DataTable GetDataTable(string sqlQuery)
        {

            DataTable datatable = new DataTable();
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                //open connection
                connToDB.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);
                
                adapter.Fill(datatable);
                
            }

                return datatable;
        }

        public DataTable GetValueByID(string query, int id, string var)
        {
            
            DataTable datatable = new DataTable();
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                //open connection
                connToDB.Open();
                using (datatable)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connToDB))
                    {
                        cmd.Parameters.AddWithValue(var, id);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable; 
        }

        public int CountElements(string table)
        {
            int value = 0;
            string query = "select count(*) from "+table+"";
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    connToDB.Open();
                    value = (int)cmd.ExecuteScalar();
                }
            }
                return value;
        }

        public string[] ReturnAllByColumnName(string table, string columnName, string query)
        {

            DBConnection dbcon = DBConnection.getInstanceOfDBConnection();
            int length = dbcon.CountElements(table);
            string[] value;
            value = new string[length];
            SqlDataReader dt;
           
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                
                

                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    connToDB.Open();
                    dt = cmd.ExecuteReader();
                    int i = 0;
                    while (dt.Read())
                    {
                        value[i] = dt[columnName].ToString();

                        i++;

                    }

                }
            }
            

            return value;
        }

    }
}
