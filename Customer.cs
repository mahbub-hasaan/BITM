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
    public partial class Customer : Form
    {
        Database db=new Database();
        public Customer()
        {
            InitializeComponent();
            ShowCustomer();
        }
        private void ShowCustomer()
        {
            string command = @"SELECT [Id],[Name],[Phone],[Address]FROM [dbo].[Customer]";
            DataTable dataTable=new DataTable();
            dataTable = db.GetData(command);
            if (dataTable.Rows.Count <= 0)
            {
                customerDataGridView.DataSource = null;
            }
            else
            {
                customerDataGridView.DataSource = dataTable;
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string command = @"INSERT INTO [dbo].[Customer]([Name],[Phone],[Address])VALUES('"+nameTextBox.Text+"','"+phoneTextBox.Text+"','"+addressTextBox.Text+"')";
            MessageBox.Show(db.Insert(command));
            ShowCustomer();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string command = @"SELECT [Id],[Name],[Phone],[Address]FROM [dbo].[Customer] where Name='"+searchTextBox.Text+"'";
            DataTable dataTable = new DataTable();
            dataTable = db.GetData(command);
            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("No customer found");
                customerDataGridView.DataSource = null;
            }
            else
            {
                customerDataGridView.DataSource = dataTable;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string command = @"UPDATE [dbo].[Customer]SET [Name] ='"+updateNameTextBox.Text+"',[Phone] ='"+updatePhoneTextBox.Text+"',[Address] ='"+updateAddressTextBox.Text+"' WHERE Id='"+Convert.ToInt32(updateIdTextBox.Text)+"'";
            MessageBox.Show(db.Update(command));
            ShowCustomer();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string command = @"DELETE FROM [dbo].[Customer]WHERE Id='"+deleteIdTextBox.Text+"'";
            MessageBox.Show(db.Delete(command));
            ShowCustomer();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {

        }

        private void ItemsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Item item =new Item();
            item.Show();
        }
    }
}
