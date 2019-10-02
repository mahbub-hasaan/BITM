using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BITM_Works.Models;
using BITM_Works.BLL;
namespace BITM_Works
{
    public partial class CustomerUI : Form
    {
        CustomerManager _customerManager=new CustomerManager();
        public CustomerUI()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer=new Customer();
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name cannot be empty");
                return;
            }

            customer.Name = nameTextBox.Text;
            customer.Contract = phoneTextBox.Text;
            customer.Addess = addressTextBox.Text;
            if(_customerManager.Add(customer))
            {
                MessageBox.Show("Successfully Added");
                ShowItems();
                return;
            }
            else
            {
                MessageBox.Show("Customer not added");
                return;
            }
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void ShowItems()
        {
            DataTable itemDataTable = new DataTable();
            itemDataTable = _customerManager.Display();
            if (itemDataTable.Rows.Count <= 0)
            {
                MessageBox.Show("No item found");
                return;
            }
            else
            {
                customerDataGridView.DataSource = itemDataTable;
            }
        }
    }
}
