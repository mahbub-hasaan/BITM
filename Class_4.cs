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
        List<int> userAge= new List<int> { };
        public Class_4()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            userName.Add(nameTextBox.Text);
            userAge.Add(Convert.ToInt32(AgeTextBox.Text));
            ShowData();
            MessageBox.Show("Added");
            AgeTextBox.Text = "";
            nameTextBox.Text = "";
        }


        private void ShowData()
        {
            ShowRichTextBox.Text = "";
            for(int i=0; i <userAge.Count();i++)
            {
                ShowRichTextBox.Text +="Name: " +userName[i] + "\n Age: "+userAge[i]+"\n\n\n";
            }
        }
    }
}
