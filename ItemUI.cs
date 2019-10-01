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
    public partial class ItemUI : Form
    {
        ItemManager _itemManager=new ItemManager();
        public ItemUI()
        {
            InitializeComponent();
           
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Item item=new Item();
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Property cannot be Empty");
                return;
            }

            item.Price = Convert.ToDouble(priceTextBox.Text);
            item.Name = nameTextBox.Text;
            if (_itemManager.IsNameExists(item))
            {
                MessageBox.Show("Name Already Esist!");
                return;
            }

            if (_itemManager.Add(item))
            {
                MessageBox.Show("Item adde");
                ShowData();
            }
            else
            {
                MessageBox.Show("Item Not Added");
            }
        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            DataTable dataTable = new DataTable();
            dataTable = _itemManager.Display();
            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                showDataGridView.DataSource = dataTable;
            }
        }
        private void ItemUI_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Item item=new Item();
            item.Id = Convert.ToInt32(itemComboBox.SelectedValue);
            bool isDeleted=_itemManager.Delete(item);
            if (isDeleted)
            {
                MessageBox.Show("Item deleted");
                LoadCombo();
                return;
            }

            else
            {
                MessageBox.Show("Item not Deleted");
                return;
            }
        }

        private void LoadCombo()
        {
            itemComboBox.DataSource = _itemManager.ItemCombo();
        }
    }
}
