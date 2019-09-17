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
    public partial class AssignmentFour : Form
    {
        List<string> customerName = new List<string> { };
        List<string> cuastomerContract = new List<string> { };
        List<string> customerAddress = new List<string> { };
        List<string> Order = new List<string> { };
        List<int> Quantity = new List<int> { };
        List<double> totalPrice = new List<double> { };
        public AssignmentFour()
        {
            InitializeComponent();          
            quantityNumericUpDown.Minimum = 1;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!cuastomerContract.Contains(contarctTextBox.Text))
            {
                if (!String.IsNullOrEmpty(orderComboBox.Text))
                {
                    if (quantityNumericUpDown != null)
                    {
                        displayRichTextBox.Clear();
                        customerName.Add(customerNameTextBox.Text);
                        customerAddress.Add(addressTextBox.Text);
                        cuastomerContract.Add(contarctTextBox.Text);
                        Order.Add(orderComboBox.Text);
                        Quantity.Add(Convert.ToInt32(quantityNumericUpDown.Value));
                        totalPrice.Add(Convert.ToInt32(quantityNumericUpDown.Value) * PiceCount(orderComboBox.Text));
                        displayRichTextBox.Text = "Order Information: " + "\n Name: " + customerNameTextBox.Text + "\n Contract No: " + contarctTextBox.Text + "\n Address: " +
                            addressTextBox.Text + "\n Order: " + orderComboBox.Text + "\n Quantity: " + Convert.ToInt32(quantityNumericUpDown.Value) + "\n Total Price: " + 
                            Convert.ToInt32(quantityNumericUpDown.Value) * PiceCount(orderComboBox.Text) + "\n \n";
                    }
                    else
                    {
                        MessageBox.Show("Please enter quantity");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Plase select order");
                    return;
                }
            }
            else
            {
                MessageBox.Show("This Contract no already exist!");
                return;
            }
        }

        private double PiceCount(string item)
        {
            if (item == "Black")
            {
                return 120;
            }
            else if (item == "Cold")
            {
                return 100;
            }
            else if (item == "Hot")
            {
                return 90;
            }
            else if (item == "Regular")
            {
                return 80;
            }
            else
            {
                return 0;
            }
        }     
        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            displayRichTextBox.Clear();
            for (int i = 0; i < customerName.Count(); i++)
            {
                displayRichTextBox.Text += "Name: " + customerName[i] + "\nContract No: " + cuastomerContract[i] + "\nAddress: " +
                            customerAddress[i] + "\nOrder: " + Order[i] + "\nQuantity: " + Quantity[i] + "\nTotal Price: " + totalPrice[i] + "\n \n";
            }
        }
    }
}
