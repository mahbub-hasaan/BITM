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
    public partial class Item : Form
    {
        Database db = new Database();
        public Item()
        {
            InitializeComponent();
            ShowItems();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string command = @"INSERT INTO [dbo].[Item]([Name],[Price])VALUES('"+nameTextBox.Text.ToUpper() + "','"+Convert.ToDouble(priceTextBox.Text)+"')";
            MessageBox.Show(db.Insert(command));
            ShowItems();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string command = @"DELETE FROM [dbo].[Item] WHERE Id='"+deleteTextBox.Text+"'";           
            MessageBox.Show(db.Delete(command));
            ShowItems();
        }

        private void ShowItems()
        {
            string command = @"Select*from Item";
            showDataGridView.DataSource = db.GetData(command);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string updateCommand = @"UPDATE [dbo].[Item]SET [Name] ='"+UpdateNameTextBox.Text.ToUpper()+"',[Price] ='"+Convert.ToDouble(UpdatePriceTextBox.Text) +"' WHERE Id='"+Convert.ToInt32(UpdateIdTextBox.Text) +"'";
            ShowItems();
            MessageBox.Show(db.Update(updateCommand));
        }

        private void SerachButton_Click(object sender, EventArgs e)
        {
            string searchCommand = @"SELECT [Id],[Name],[Price]FROM [dbo].[Item] where Name='"+searchTextBox.Text.ToUpper()+ "'";
            DataTable searchData=new DataTable();
            searchData = db.GetData(searchCommand);
            if (searchData.Rows.Count <= 0)
            {
                showDataGridView.DataSource = null;
                MessageBox.Show("No item found");
            }
            else
            {
                showDataGridView.DataSource = searchData;
            }
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer=new Customer();
            customer.Show();
            this.Hide();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders orders=new Orders();
            orders.Show();
        }
    }
}
