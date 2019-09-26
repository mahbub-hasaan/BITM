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
        }
    }
}
