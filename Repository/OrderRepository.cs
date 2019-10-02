using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BITM_Works.Models;
using BITM_Works.BLL;
namespace BITM_Works.Repository
{
    class OrderRepository
    {
        Database db=new Database();
        public DataTable ItemCombo()
        {
            string commandString = @"SELECT Id,Name FROM Items";
            return db.GetDataTable(commandString);
        }
        public DataTable CustomerCombo()
        {
            string commandString = @"SELECT Id,Name FROM [dbo].[Customers]";
            return db.GetDataTable(commandString);
        }

        public double GetItemPrice(int id)
        {
            string commandString = @"select cast(price as int) from items where id='"+id+"'";
            return db.ExecuteScalar(commandString);
        }

        public bool Add(Order order)
        {
            bool isAdded = false;
            string commandString = @"INSERT INTO [dbo].[Orders]([CustomerId],[ItemId],[Quantity],[TotalPrice]) Values ('" + order.CustomerId+ "','" + order.ItemId + "','" + order.Quantity + "','" + order.TotalPrice + "')";
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
            string commandString = @"SELECT o.Id,c.Name as Customer,Contact,i.Name as Item,i.Price,o.Quantity,o.TotalPrice AS Total FROM Orders as o LEFT JOIN Customers as c on c.Id=o.customerId LEFT JOIN Items as i on i.Id=o.ItemId";
            return db.GetDataTable(commandString);
        }
    }
}
