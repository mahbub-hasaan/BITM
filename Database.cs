using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BITM_Works
{
    class Database
    {
        static string connectionString = @"Server=PC-301-01\SQLEXPRESS;Database=BITM;Trusted_Connection=True";
        SqlConnection connection = new SqlConnection(connectionString);       
        public string ExecuteNoncommand(string command)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                return "Successfully Inserted";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }         
        }
    }
}
