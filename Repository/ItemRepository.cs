using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BITM_Works.BLL;
using BITM_Works.Models;
namespace BITM_Works.Repository
{
    class ItemRepository
    {
        Database db=new Database();
        public bool Add(Item item)
        {
            bool isAdded = false;
            string commandString = @"INSERT INTO Items (Name, Price) Values ('" + item.Name + "', " + item.Price + ")";
            try
            {
                isAdded=db.ExecuteNonQuery(commandString);
            }
            catch (Exception ex)
            {
               //Exceptions
            }

            return isAdded;
        }
        public bool IsNameExists(Item item)
        {
            bool exists = false;
            try
            {
                string commandString = @"SELECT * FROM Items WHERE Name='" + item.Name + "'";
                if (db.GetDataTable(commandString).Rows.Count > 0)
                {
                    exists = true;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show();
            }

            return exists;
        }
        public bool Delete(Item item)
        {
            bool isExecute = false;
            try
            {
                string commandString = @"DELETE FROM Items WHERE Id = " + item.Id + "";
                isExecute = db.ExecuteNonQuery(commandString);
            }
            catch (Exception)
            {
                // MessageBox.Show();
            }

            return isExecute;
        }
        public DataTable Display()
        {
            string commandString = @"SELECT * FROM Items";
            return db.GetDataTable(commandString);
        }
        public DataTable ItemCombo()
        {
            string commandString = @"SELECT Id,Name FROM Items";
            return db.GetDataTable(commandString);
        }

        public bool Update(Item item)
        {
            bool isUpdated = false;
            string commandString = @"UPDATE [dbo].[Items]SET [Name] ='"+item.Name+"' ,[Price] ='"+item.Price+"'WHERE Id='" + item.Id + "'";
            try
            {
                isUpdated = db.ExecuteNonQuery(commandString);
            }
            catch (Exception e)
            {

            }

            return isUpdated;
        }

        public DataTable Search(string name)
        {
            string commandString = @"SELECT * FROM Items Where Name='"+name+"'";
            return db.GetDataTable(commandString);
        }
    }
}
