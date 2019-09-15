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
    public partial class Assiginment_3 : Form
    {
        const int arraySize = 20;
        string[] customerName = new string[arraySize];
        string[] customerContract = new string[arraySize];
        string[] customerAddress = new string[arraySize];
        string[] Order = new string[arraySize];
        int[] Quantity = new int[arraySize];
        double[] totalPrice = new double[arraySize];

        int Index = 0;
        public Assiginment_3()
        {
            InitializeComponent();
            quantityNumericUpDown.Maximum = 100000;
            quantityNumericUpDown.Minimum = 1;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Index < arraySize)
            {
                if(nameTextBox.Text!="" && contaractTextBox.Text!="" && addressTextBox.Text!="" && orderComboBox.Text != "")
                {
                    customerName[Index] = nameTextBox.Text;
                    customerContract[Index] = contaractTextBox.Text;
                    customerAddress[Index] = addressTextBox.Text;
                    Order[Index] = orderComboBox.Text;
                    Quantity[Index] = Convert.ToInt32(quantityNumericUpDown.Value);
                    totalPrice[Index] = Quantity[Index] * PiceCount(orderComboBox.Text);
                }
                else
                {
                    MessageBox.Show("Wrong Input!");
                }
            }
            else
            {
                MessageBox.Show("Memory full..!!");
            }
        }

        private double PiceCount(string item)
        {
            if (item == "Black")
            {
                return 120;
            }
            else if (item=="Cold")
            {
                return 100;
            }
            else if (item == "Hot")
            {
                return 90;
            }
            else if(item=="Regular")
            {
                return 80;
            }
            else
            {
                return 0;
            }
        }
    }
}
