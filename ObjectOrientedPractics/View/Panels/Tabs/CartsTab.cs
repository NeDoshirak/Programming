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
    public partial class CartsTab : UserControl
    {
        public CartsTab()
        {
            InitializeComponent();
        }

        internal List<Item> Items { get; set; } = new List<Item>();
        internal List<Customer> Customers { get; set; } = new List<Customer>();
        private Customer _currentCustomer;

        private void UpdateInfo()
        {
            if (_currentCustomer.Cart!= null)
            {
                CartListBox.Items.Clear();
                CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
                AmouthLabel.Text = _currentCustomer.Cart.Amount.ToString();
            }
        }

        public void RefreshData()
        {
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(Items.ToArray());

            CustomersComboBox.Items.Clear();
            CustomersComboBox.Items.AddRange(Customers.ToArray());
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
                UpdateInfo();
            }
            else
            {
                CartListBox.Items.Clear();
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && ItemsListBox.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
                UpdateInfo();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && CartListBox.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.Remove(Items[CartListBox.SelectedIndex]);
                UpdateInfo();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.Cart.Items.Clear();
                UpdateInfo();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            int CurrentCustomer = CustomersComboBox.SelectedIndex;
            Customer test = Customers[CurrentCustomer];
            if (CurrentCustomer < 0 || CartListBox.Items.Count == 0)
            {
                return;
            }

            var items = new List<Item>();

            foreach (var item in Customers[CurrentCustomer].Cart.Items)
            {
                items.Add(new Item(item));
            }

            var order = new Order(
                OrderStatus.New,
                Customers[CurrentCustomer].Address,
                items,
                DateTime.Now);

            Customers[CurrentCustomer].Orders.Add(order);
            Customers[CurrentCustomer].Cart.Items.Clear();
            UpdateInfo();
        }
    }
}
