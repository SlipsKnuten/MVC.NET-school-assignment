using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace a15gusbe.Models
{
    public class AlienModel
    {
        private string connectionString = "";

        public AlienModel(string connectionName)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public DataTable GetAllAliens()
        {
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Alien;", dbcon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "result");
            DataTable studentsTable = ds.Tables["result"];
            dbcon.Close();

            return studentsTable;
        }

        public void DeleteAlien(int? id)
        {
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            dbcon.Open();
            string deleteString = "DELETE FROM Alien WHERE id=@ID;";
            MySqlCommand sqlCmd = new MySqlCommand(deleteString, dbcon);
            sqlCmd.Parameters.AddWithValue("@ID", id);
            sqlCmd.ExecuteNonQuery();
            dbcon.Close();
        }

        /*public void InsertAlien(int? id)
        {

            for (int i = 0; i<0; i++)
            {

                MySqlConnection dbcon = new MySqlConnection(connectionString);
                dbcon.Open();
                string deleteString = "INSERT INTO Alien (id, Pnr) VALUES(@ID, @PNR); ";
                MySqlCommand sqlCmd = new MySqlCommand(deleteString, dbcon);
                sqlCmd.Parameters.AddWithValue("@ID", i);
                sqlCmd.Parameters.AddWithValue("@PNR", i);
                sqlCmd.ExecuteNonQuery();
                dbcon.Close();
            }
        }*/
  
    }
}