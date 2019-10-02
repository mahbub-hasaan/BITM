using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BITM_Works.Models;
using BITM_Works.BLL;
namespace BITM_Works
{
    public partial class OrderUI : Form
    {
        OrderManager _orderManager=new OrderManager();
        public OrderUI()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Order order=new Order();
            if(String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Quantity Cannot be empty");
                return;
            }
            if (!Regex.IsMatch(quantityTextBox.Text, @"^[0-9-]*$"))
            {
                MessageBox.Show("Enter Number");
                return;
            }

            order.CustomerId = Convert.ToInt32(customerComboBox.SelectedValue);
            order.ItemId = Convert.ToInt32(itemComboBox.SelectedValue);
            order.Quantity = Convert.ToInt32(quantityTextBox.Text);
            order.TotalPrice = Convert.ToInt32(totalPriceTextBox.Text);
            if (_orderManager.Add(order))
            {
                MessageBox.Show("Item Successfully Added");
                ShowItems();
                return;
            }
            else
            {
                MessageBox.Show("Item not added");
            }
        }

        private void OrderUI_Load(object sender, EventArgs e)
        {
            ItemCombo();
            CustomerCombo();
            ShowItems();
        }

        private void ItemCombo()
        {
            itemComboBox.DataSource = _orderManager.ItemCombo();
        }

        private void CustomerCombo()
        {
            customerComboBox.DataSource = _orderManager.CustomerCombo();
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                
                //MessageBox.Show("Quantity Cannot be empty");
                return;
            }
            if (!Regex.IsMatch(quantityTextBox.Text, @"^[0-9-]*$"))
            {
                MessageBox.Show("Enter Number");
                return;
            }

            double price = _orderManager.GetItemPrice(Convert.ToInt32(itemComboBox.SelectedValue));
            double totalPrice = price * Convert.ToInt32(quantityTextBox.Text);
            totalPriceTextBox.Text = totalPrice.ToString();
        }

        private void ShowItems()
        {
            DataTable itemDataTable = new DataTable();
            itemDataTable = _orderManager.Display();
            if (itemDataTable.Rows.Count <= 0)
            {
                MessageBox.Show("No item found");
                return;
            }
            else
            {
                orderDataGridView.DataSource = itemDataTable;
            }
        }
    }
}
