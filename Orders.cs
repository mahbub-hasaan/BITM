using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITM_Works
{
    public partial class Orders : Form
    {
        Database db=new Database();
        double Price;
        public Orders()
        {
            InitializeComponent();
            ShowOrders();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ItemTextBox_TextChanged(object sender, EventArgs e)
        {
            //string command = @"SELECT [Price] FROM [dbo].[Item] where Name='"+itemTextBox.Text.ToUpper()+"'";
            //foreach (DataRow rows in db.GetData(command).Rows)
            //{
            //    Price =Convert.ToDouble(rows["Price"].ToString());
            //}
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            //int quantity = Convert.ToInt32(quantityTextBox.Text);
            //double totalPrice = Price * Convert.ToInt32(quantityTextBox.Text);
            //string command = @"INSERT INTO [dbo].[Order]([CustomerName],[ItemName],[TotalPrice],[Quantity])VALUES('"+customerNameTextBox.Text+"','"+itemTextBox.Text+"',"+totalPrice+","+ quantity + ")";
            //MessageBox.Show(db.Insert(command));
            //ShowOrders();
        }

        private void ShowOrders()
        {
            //string command = @"SELECT * FROM [dbo].[Order]";
            //DataTable dataTable=new DataTable();
            //dataTable = db.GetData(command);
            //if (dataTable.Rows.Count <= 0)
            //{
            //   // MessageBox.Show("No customer found");
            //    ordersDataGridView.DataSource = null;
            //}
            //else
            //{
            //    ordersDataGridView.DataSource = dataTable;
            //}
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //string command = @"SELECT * FROM [dbo].[Order] Where CustomerName='"+serachTextBox.Text+"'";
            //DataTable dataTable = new DataTable();
            //dataTable = db.GetData(command);
            //if (dataTable.Rows.Count <= 0)
            //{
            //    MessageBox.Show("No Order found");
            //    ordersDataGridView.DataSource = null;
            //}
            //else
            //{
            //    ordersDataGridView.DataSource = dataTable;
            //}
        }

        private void DelteButton_Click(object sender, EventArgs e)
        {
            //string command = @"DELETE FROM [dbo].[Order] WHERE Id='" + deleteIdTextBox.Text + "'";
            //MessageBox.Show(db.Delete(command));
            //ShowOrders();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            ShowOrders();
        }

    }
}
