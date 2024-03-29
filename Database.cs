﻿using System;
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
        static string connectionString = @"Server=DESKTOP-6ON225A\SQLEXPRESS;Database=BITM;Trusted_Connection=True";
        SqlConnection connection = new SqlConnection(connectionString);
        
        public string Insert(string command)
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

        public DataTable GetData(string command)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                connection.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string Delete(string command)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                return "Successfully Deleted";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Update(string command)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                return "Update Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
