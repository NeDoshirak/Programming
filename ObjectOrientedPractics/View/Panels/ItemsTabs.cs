using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ObjectOrientedPractics.View.Panels
{
    public partial class ItemsTabs : UserControl
    {
        public ItemsTabs()
        {
            InitializeComponent();
        }

        internal List<Item> Items { get; set; } = new List<Item>();

        private void CategoryComboBox_Enter(object sender, EventArgs e)
        {
            if (CategoryComboBox.Items.Count == 0)
            {
                CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<Object>().ToArray());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Items != null)
            {
                Item item = new Item("---", "---", 0, Category.None);
                Items.Add(item);
                ItemsListBox.Items.Add(item);
                ItemsListBox.SelectedIndex = Items.Count - 1;
                UpdateTextBoxInfo(Items[ItemsListBox.SelectedIndex]);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                var index = ItemsListBox.SelectedIndex;
                Items.RemoveAt(index);
                ItemsListBox.Items.RemoveAt(index);
                ClearTextBox();
            }

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                UpdateTextBoxInfo(Items[ItemsListBox.SelectedIndex]);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            { 
                Items[ItemsListBox.SelectedIndex].Category = Enum.Parse<Category>(CategoryComboBox.Text);
            }
        }

        private void UpdateTextBoxInfo(Item item)
        {
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name.ToString();
            DescriptionTextBox.Text = item.Info.ToString();
            CategoryComboBox.Text = item.Category.ToString();
        }

        private void ClearTextBox()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            CategoryComboBox.Text = string.Empty;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = Color.White;
                int index = ItemsListBox.SelectedIndex;
                if (index >= 0)
                {
                    Items[index].Cost = Convert.ToInt32(CostTextBox.Text);
                }
            }
            catch
            {
                CostTextBox.BackColor = Color.Red;
            };
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.White;
                int index = ItemsListBox.SelectedIndex;
                if (index >= 0)
                {
                    Items[index].Name = NameTextBox.Text;
                }
            }
            catch
            {
                NameTextBox.BackColor = Color.Red;
            };
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DescriptionTextBox.BackColor = Color.White;
                int index = ItemsListBox.SelectedIndex;
                if (index >= 0)
                {
                    Items[index].Info = DescriptionTextBox.Text;
                }
            }
            catch
            {
                DescriptionTextBox.BackColor = Color.Red;
            };
        }

        private void CostTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = Items[ItemsListBox.SelectedIndex];
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = Items[ItemsListBox.SelectedIndex];
            }
        }

        private void DescriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = Items[ItemsListBox.SelectedIndex];
            }
        }


    }
}
