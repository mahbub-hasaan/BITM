using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  BITM_Works.BLL;
using BITM_Works.Models;
namespace BITM_Works.Repository
{
    class CustomerRepository
    {
        Database db=new Database();
        public bool Add(Customer customer)
        {
            bool isAdded = false;
            string commandString = @"INSERT INTO [dbo].[Customers]([Name],[Address],[Contact]) Values ('" + customer.Name + "', '" + customer.Addess + "','"+customer.Contract+"')";
            try
            {
                isAdded = db.ExecuteNonQuery(commandString);
            }
            catch (Exception ex)
            {
                //Exceptions
            }

            return isAdded;
        }

        public DataTable Display()
        {
            string commandString = @"SELECT * FROM Customers";
            return db.GetDataTable(commandString);
        }
    }
}
