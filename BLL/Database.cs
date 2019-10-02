using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BITM_Works
{
    class Database
    {
        public bool ExecuteNonQuery(string command)
        {
            string connectionString = @"Server=DESKTOP-6ON225A\SQLEXPRESS;Database=BITM;Trusted_Connection=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(exeption.Message);
            }
            return false;
        }

        public DataTable GetDataTable(string command)
        {
            string connectionString = @"Server=DESKTOP-6ON225A\SQLEXPRESS;Database=BITM;Trusted_Connection=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public double ExecuteScalar(string command)
        {
            try
            {
                string connectionString = @"Server=DESKTOP-6ON225A\SQLEXPRESS;Database=BITM;Trusted_Connection=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                double result = Convert.ToDouble(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                sqlConnection.Close();
                //MessageBox.Show(" No. of Rows " + count);
                return result;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
            }

            return 0;
        }
    }
}
