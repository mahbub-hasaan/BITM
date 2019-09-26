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
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string command = @"INSERT INTO [dbo].[Item]([ItemName],[ItemPrice],[Stock])VALUES('"+nameTextBox.Text+"','"+priceTextBox.Text+"','"+stockTextBox.Text+"')";
            MessageBox.Show(db.ExecuteNoncommand(command));
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
    }
}
