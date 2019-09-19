using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace BITM_Works
{
    public partial class ClasssFive : Form
    {
        List<string> studentId = new List<string> { };
        List<string> studentName = new List<string> { };
        List<string> studentMobile = new List<string> { };
        List<int> studentAge = new List<int> { };
        List<string> studentAddress = new List<string> { };
        List<double> studentGpaPoint = new List<double> { };

        public ClasssFive()
        {
            InitializeComponent();
            resultGroupBox.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!studentId.Contains(idTextBox.Text) && idTextBox.TextLength==4 && !String.IsNullOrEmpty(idTextBox.Text))
            {
                if(!String.IsNullOrEmpty(nameTextBox.Text) && nameTextBox.Text.Length <= 50)
                {
                    if(!String.IsNullOrEmpty(mobileTextBox.Text) && mobileTextBox.TextLength == 11 && !studentMobile.Contains(mobileTextBox.Text))
                    {
                        if (!String.IsNullOrEmpty(ageTextBox.Text) && !Regex.IsMatch(ageTextBox.Text, "[^0-9]"))
                        {
                            if (!String.IsNullOrEmpty(gpaTextBox.Text) &&!Regex.IsMatch(gpaTextBox.Text, "/^[0-9]+(\\.[0-9]+)?$") && Convert.ToDouble(gpaTextBox.Text)>=0 && Convert.ToDouble(gpaTextBox.Text)<=4)
                            {
                                studentId.Add(idTextBox.Text);
                                studentName.Add(nameTextBox.Text);
                                studentMobile.Add(mobileTextBox.Text);
                                studentAge.Add(Convert.ToInt32(ageTextBox.Text));
                                studentAddress.Add(AddressTextBox.Text);
                                studentGpaPoint.Add(Convert.ToDouble(gpaTextBox.Text));
                                displayRichTextBox.Clear();
                                displayRichTextBox.Text = "Id: " + idTextBox.Text + "\n Name: " + nameTextBox.Text + "\n Mobile: " + mobileTextBox.Text+"\n Age: "+ageTextBox.Text+"\n Address: "+AddressTextBox.Text+"\n GPA: "+gpaTextBox.Text;
                                resultGroupBox.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Enter valid GPA");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter valid Age");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter valid Mobile No");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Enter valid name");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter valid Id");
                return;
            }
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            displayRichTextBox.Clear();
            for(int i = 0; i < studentId.Count(); i++)
            {
                displayRichTextBox.Text += "Id: " +studentId[i]+ "\n Name: " +studentName[i]+ "\n Mobile: " + studentMobile[i]+ "\n Age: " +studentAge[i]+ "\n Address: " + studentAddress[i] + "\n GPA: " +studentGpaPoint[i]+"\n \n";
            }
            resultGroupBox.Show();
            maxTextBox.Text=studentGpaPoint.Max().ToString();
            minTextBox.Text=studentGpaPoint.Min().ToString();
            avgTextBox.Text=studentGpaPoint.Average().ToString();
            int maxIndex = studentGpaPoint.IndexOf(studentGpaPoint.Max());
            int minIndex = studentGpaPoint.IndexOf(studentGpaPoint.Min());
            maxNameTextBox.Text = studentName[maxIndex].ToString();
            minNameTextBox.Text = studentName[minIndex].ToString();
            totalTextBox.Text = studentGpaPoint.Sum().ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int searchIndex;
            displayRichTextBox.Clear();
            if (idRadioButton.Checked)
            {
                searchIndex = studentId.IndexOf(studentId.Find(x => x.Equals(idTextBox.Text)));
                SearchStudent(searchIndex);
            }
            else if (nameRadioButton.Checked)
            {
                searchIndex = studentName.IndexOf(studentName.Find(x => x.Equals(nameTextBox.Text)));
                SearchStudent(searchIndex);
            }
            else if (mobileRadioButton.Checked)
            {
                searchIndex = studentMobile.IndexOf(studentMobile.Find(x => x.Equals(mobileTextBox.Text)));
                SearchStudent(searchIndex);
            }
            else
            {
                MessageBox.Show(text: "Select an option");
                return;
            }
        }


        private void SearchStudent(int i)
        {
            if (!i.Equals(-1))
            {
                displayRichTextBox.Clear();
                displayRichTextBox.Text += "Id: " + studentId[i] + "\n Name: " + studentName[i] + "\n Mobile: " + studentMobile[i] + "\n Age: " + studentAge[i] + "\n Address: " + studentAddress[i] + "\n GPA: " + studentGpaPoint[i] + "\n \n";
            }
            else
            {
                MessageBox.Show("No information found");
                return;
            }
        }

    }
}
