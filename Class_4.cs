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
    public partial class Class_4 : Form
    {
        List<string> userName = new List<string> { };
        public Class_4()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            userName.Add(nameTextBox.Text);
            ShowData();
        }


        private void ShowData()
        {
            ShowRichTextBox.Text = "";
            foreach (string names in userName)
            {
                ShowRichTextBox.Text += names + "\n";
            }
        }
    }
}
