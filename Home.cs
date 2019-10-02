using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BITM_Works
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ItemsButton_Click(object sender, EventArgs e)
        {
            ItemUI itemUi=new ItemUI();
            this.Hide();
            itemUi.Show();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            CustomerUI customerUi=new CustomerUI();
            this.Hide();
            customerUi.Show();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            OrderUI orderUi=new OrderUI();
            this.Hide();
            orderUi.Show();
        }
    }
}
