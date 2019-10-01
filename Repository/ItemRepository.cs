using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BITM_Works.Models;
namespace BITM_Works.Repository
{
    class ItemRepository
    {
        public bool Add(Item item)
        {
            bool isAdded = false;
            try
            {
                //Connection
                string connectionString = @"Server=PC-301-04\SQLEXPRESS;Database=BITM;Trusted_Connection=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"INSERT INTO Items (Name, Price) Values ('" + item.Name+ "', " + item.Price + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
               throw exeption;
            }

            return isAdded;
        }
        public bool IsNameExists(Item item)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=PC-301-04\SQLEXPRESS;Database=BITM;Trusted_Connection=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Items WHERE Name='" + item.Name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }
        public bool Delete(Item item)
        {
            try
            {
                //Connection
                string connectionString = @"Server=PC-301-04\SQLEXPRESS;Database=BITM;Trusted_Connection=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //DELETE FROM Items WHERE ID = 3
                string commandString = @"DELETE FROM Items WHERE Id = " + item.Id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Delete
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }


                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                // MessageBox.Show(exeption.Message);
            }

            return false;
        }
        public DataTable Display()
        {
            string connectionString = @"Server=PC-301-04\SQLEXPRESS;Database=BITM;Trusted_Connection=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public DataTable ItemCombo()
        {
            string connectionString = @"Server=PC-301-04\SQLEXPRESS;Database=BITM;Trusted_Connection=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT Id,Name FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;

        }
    }
}
