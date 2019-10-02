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
    public partial class ItemUI : Form
    {
        ItemManager _itemManager=new ItemManager();
        Item selectedItem = new Item();
        public ItemUI()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Item item=new Item();
            if (String.IsNullOrEmpty(itemPriceTextBox.Text))
            {
                MessageBox.Show("Price cannot be empty");
                return;
            }

            if (!Regex.IsMatch(itemPriceTextBox.Text, @"-?\d+(?:\.\d+)?"))
            {
                MessageBox.Show("Enter Price properly");
                return;
            }

            item.Name = itemNameTextBox.Text;
            item.Price = Convert.ToDouble(itemPriceTextBox.Text);
            if (_itemManager.IsNameExists(item))
            {
                MessageBox.Show("This name already exist!");
                return;
            }

            if (_itemManager.Add(item))
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

        private void ShowItems()
        {
            DataTable itemDataTable=new DataTable();
            itemDataTable = _itemManager.Display();
            if (itemDataTable.Rows.Count <= 0)
            {
                MessageBox.Show("No item found");
                return;
            }
            else
            {
                itemDataGridView.DataSource = itemDataTable;
            }
        }

        private void ItemUI_Load(object sender, EventArgs e)
        {
            ShowItems();
            //selectedItem = null;
        }
        private void ItemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!itemDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.Equals(""))
                {
                    itemDataGridView.CurrentRow.Selected = true;
                    selectedItem.Name = itemDataGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    selectedItem.Price = Convert.ToDouble(itemDataGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    selectedItem.Id = Convert.ToInt32(itemDataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    SelectedItem();
                    return;
                }
            }
            catch(Exception)
            {
                return;
            }
        }

        private void SelectedItem()
        {
            itemNameTextBox.Text = selectedItem.Name;
            itemPriceTextBox.Text = selectedItem.Price.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                string itemNamePre = selectedItem.Name;
                if (String.IsNullOrEmpty(itemPriceTextBox.Text))
                {
                    MessageBox.Show("Price cannot be empty");
                    return;
                }

                if (!Regex.IsMatch(itemPriceTextBox.Text, @"-?\d+(?:\.\d+)?"))
                {
                    MessageBox.Show("Enter Price properly");
                    return;
                }

                selectedItem.Name = itemNameTextBox.Text;
                selectedItem.Price = Convert.ToDouble(itemPriceTextBox.Text);
                if (itemNamePre != itemNameTextBox.Text)
                {
                    if (_itemManager.IsNameExists(selectedItem))
                    {
                        MessageBox.Show("This name already exist!");
                        return;
                    }
                }
                bool isUpdated = _itemManager.Update(selectedItem);
                if (isUpdated == true)
                {
                    MessageBox.Show("Item Updated");
                    ShowItems();
                }
                else
                {
                    MessageBox.Show("Cannot update this item");
                }
            }
            else
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                bool isDeleted = _itemManager.Delete(selectedItem);
                if(isDeleted==true)
                {
                    MessageBox.Show("Item Deleted");
                    ShowItems();
                }
                else
                {
                    MessageBox.Show("Cannot delete this item");
                }
            }
            else
            {
                MessageBox.Show("Select an Item");
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(itemNameTextBox.Text))
            {
                MessageBox.Show("Enter name to Serach");
                return;
            }
            DataTable iteDataTable=new DataTable();
            iteDataTable = _itemManager.Search(itemNameTextBox.Text);
            if (iteDataTable.Rows.Count <= 0)
            {
                MessageBox.Show("No Item found");
                return;
            }
            else
            {
                itemDataGridView.DataSource = iteDataTable;
                return;
            }
        }
    }
}
