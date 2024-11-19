using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
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

        private List<Item> _items;

        /// <summary>
        /// Список товаров класса <see cref="Item"/>, выведенный на экран.
        /// </summary>
        private List<Item> _displayedItems;

        /// <summary>
        /// Возвращает и задает список товаров класса <see cref="Item"/>.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;

                if (Items != null)
                {
                    UpdateDisplayedItems();
                    OrderByComboBox.SelectedIndex = 0;
                }
            }
        }

        private void UpdateItemsListBox()
        {
            var selectedItem = ItemsListBox.SelectedItem;
            ItemsListBox.Items.Clear();

            foreach (var item in DisplayedItems)
            {
                ItemsListBox.Items.Add(item);
            }

            ItemsListBox.SelectedItem = selectedItem;
        }


        /// <summary>
        /// Возвращает и задает список товаров класса <see cref="Item"/>, выведенный на экран.
        /// </summary>
        public List<Item> DisplayedItems
        {
            get => _displayedItems;
            set
            {
                _displayedItems = value;

                if (DisplayedItems != null)
                {
                    UpdateItemsListBox();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает делигат критерия сортировки.
        /// </summary>
        private DataTools.CompareProperties SortCompare { get; set; }

        /// <summary>
        /// Возвращает и задает делигат критерия фильтрации.
        /// </summary>
        private Predicate<Item> FilterCompare { get; set; }


        /// <summary>
        /// Обновить список товаров, который будет выведен на экран.
        /// </summary>
        /// <param name="compare">Метод критерия проверки товаров.</param>
        private void UpdateDisplayedItems()
        {
            var displayedItems = Items;

            if (FilterCompare != null)
            {
                displayedItems = DataTools.FilterItems(displayedItems, FilterCompare);
            }

            if (SortCompare != null)
            {
                displayedItems = DataTools.SortItems(displayedItems, SortCompare);
            }

            DisplayedItems = displayedItems;
            SetTextBoxes();
        }

        /// <summary>
        /// Устанавливает корректные данные в текстовых окнах 
        /// в зависимости от индекса товара в списке.
        /// </summary>
        /// <param name="selectedIndex">Индекс товара в списке.</param>
        private void SetTextBoxes()
        {
            var isSelectedIndexCorrect = ItemsListBox.SelectedItem != null;
            CostTextBox.Enabled = isSelectedIndexCorrect;
            NameTextBox.Enabled = isSelectedIndexCorrect;
            DescriptionTextBox.Enabled = isSelectedIndexCorrect;
            CategoryComboBox.Enabled = isSelectedIndexCorrect;

            if (isSelectedIndexCorrect)
            {
                var selectedItem = ItemsListBox.SelectedItem as Item;
                NameTextBox.Text = selectedItem.Name;
                CostTextBox.Text = selectedItem.Cost.ToString();
                IdTextBox.Text = selectedItem.Id.ToString();
                DescriptionTextBox.Text = selectedItem.Info;
                CategoryComboBox.SelectedIndex = (int)selectedItem.Category;
            }
            else
            {
                NameTextBox.Text = string.Empty;
                CostTextBox.Text = string.Empty;
                IdTextBox.Text = string.Empty;
                DescriptionTextBox.Text = string.Empty;
                CategoryComboBox.SelectedIndex = -1;
            }
        }

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

        /// <summary>
        /// Событие при изменении текста в текстовом поле поиска товаров.
        /// </summary>
        /// <param name="sender">Элемент управления, вызвавший событие.</param>
        /// <param name="e">Данные о событии.</param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text.Length == 0)
            {
                FilterCompare = null;
            }
            else
            {
                FilterCompare = (item) => { return item.Name.Contains(FindTextBox.Text); };
            }

            UpdateDisplayedItems();
        }

        /// <summary>
        /// Событие при изменении выбора в списке сортировок товара.
        /// </summary>
        /// <param name="sender">Элемент управления, вызвавший событие.</param>
        /// <param name="e">Данные о событии.</param>
        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OrderByComboBox.SelectedIndex)
            {
                case 0:
                    {
                        SortCompare = (firstItem, secondItem) =>
                        {
                            return firstItem.Name.CompareTo(secondItem.Name) < 0;
                        };

                        break;
                    }
                case 1:
                    {
                        SortCompare = (firstItem, secondItem) =>
                        {
                            return firstItem.Cost.CompareTo(secondItem.Cost) < 0;
                        };

                        break;
                    }
                case 2:
                    {
                        SortCompare = (firstItem, secondItem) =>
                        {
                            return firstItem.Cost.CompareTo(secondItem.Cost) > 0;
                        };

                        break;
                    }
            }

            var selectedItem = ItemsListBox.SelectedItem;
            UpdateDisplayedItems();
        }
    }
}
