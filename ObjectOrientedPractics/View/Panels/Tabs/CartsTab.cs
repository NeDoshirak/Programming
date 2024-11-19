using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
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

        public double DiscountAmount { get; set; }

        private void UpdateInfo()
        {
            if (_currentCustomer.Cart != null)
            {
                CartListBox.Items.Clear();
                CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
                AmouthLabel.Text = _currentCustomer.Cart.Amount.ToString();
            }
        }

        private void UpdateDiscountsCheckedListBox()
        {
            var CurrentCustomer = CustomersComboBox.SelectedIndex;
            if (Customers.Count == 0 || CurrentCustomer < 0)
            {
                DiscountsCheckedListBox.Items.Clear();
                DiscountsCheckedListBox.Enabled = false;
                return;
            }

            DiscountsCheckedListBox.Items.Clear();

            foreach (var discount in Customers[CurrentCustomer].Discounts)
            {
                DiscountsCheckedListBox.Items.Add(discount.Info);
            }

            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                DiscountsCheckedListBox.SetItemChecked(i, true);
            }

            DiscountAmountLabel.Text = Customers[CurrentCustomer].Cart.Amount.ToString();
            DiscountsCheckedListBox.Enabled = true;
            DiscountAmountLabel.Text = "0";
            TotalLabel.Text = DiscountAmountLabel.Text;
        }

        private void UpdateAmountLabels()
        {
            DiscountAmount = 0.0;
            var CurrentCustomer = CustomersComboBox.SelectedIndex;

            foreach (var item in DiscountsCheckedListBox.CheckedItems)
            {
                var index = DiscountsCheckedListBox.Items.IndexOf(item);
                DiscountAmount += Customers[CurrentCustomer].Discounts[index].Calculate(
                    Customers[CurrentCustomer].Cart.Items);
            }

            var amount = Customers[CurrentCustomer].Cart.Amount;
            DiscountAmountLabel.Text = amount.ToString();
            DiscountAmountLabel.Text = DiscountAmount.ToString();
            TotalLabel.Text = (amount - DiscountAmount).ToString();
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
                UpdateDiscountsCheckedListBox();
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
            if (_currentCustomer != null && _currentCustomer.Cart.Items.Count != 0)
            {
                var items = new List<Item>();

                foreach (var item in _currentCustomer.Cart.Items)
                {
                    items.Add(new Item(item));
                }

                if (_currentCustomer.IsPriority)
                {
                    var order = new Order(
                        _currentCustomer.Address,
                        items);
                    _currentCustomer.Orders.Add(order);
                }
                else
                {
                    var order = new PriorityOrder(
                    _currentCustomer.Address,
                    items, DateTime.Now, OrderTime.f9t11);

                    _currentCustomer.Orders.Add(order);
                }

                _currentCustomer.Cart.Items.Clear();
                UpdateInfo();
            }
        }

        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateAmountLabels();
        }
    }
}
