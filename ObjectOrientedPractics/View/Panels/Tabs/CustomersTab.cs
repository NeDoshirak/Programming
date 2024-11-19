using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
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
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
        }

        internal List<Customer> Customers { get; set; } = new List<Customer>();

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer("---", new Address());
            Customers.Add(customer);
            CustomersListBox.Items.Add(customer);
            CustomersListBox.SelectedIndex = Customers.Count - 1;
        }

        private void ClearTextBox()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
        }

        private void UpdateDiscountsListBox(Customer customer)
        {
            DiscountsListBox.Items.Clear();

            foreach (var discount in customer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                var index = CustomersListBox.SelectedIndex;
                Customers.RemoveAt(index);
                CustomersListBox.Items.RemoveAt(index);
                ClearTextBox();
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                var _currentCustomer = Customers[CustomersListBox.SelectedIndex];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressControl.currentAddress = _currentCustomer.Address;
                CheckBox.Checked = _currentCustomer.IsPriority;
                AddressControl.UpdateControl();
            }

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullNameTextBox.BackColor = Color.White;
                int index = CustomersListBox.SelectedIndex;
                if (index >= 0)
                {
                    Customers[index].FullName = FullNameTextBox.Text;
                }
            }
            catch
            {
                FullNameTextBox.BackColor = Color.Red;
            };
        }


        private void FullNameTextBox_Leave(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = Customers[CustomersListBox.SelectedIndex];
            }
        }

        private void AddressControl_Leave(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = Customers[CustomersListBox.SelectedIndex];
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                Customers[CustomersListBox.SelectedIndex].IsPriority = CheckBox.Checked;
            }
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                var addDiscountPopUp = new AddDiscountPopUp(Customers[CustomersListBox.SelectedIndex]);

                if (addDiscountPopUp.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var discount = new PercentDiscount(addDiscountPopUp.Category);
                Customers[CustomersListBox.SelectedIndex].Discounts.Add(discount);
                UpdateDiscountsListBox(Customers[CustomersListBox.SelectedIndex]);
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                var removedIndex = DiscountsListBox.SelectedIndex;
                Customers[CustomersListBox.SelectedIndex].Discounts.RemoveAt(
                    DiscountsListBox.SelectedIndex);
                UpdateDiscountsListBox(Customers[CustomersListBox.SelectedIndex]);

                if (removedIndex >= DiscountsListBox.Items.Count)
                {
                    DiscountsListBox.SelectedIndex = removedIndex - 1;
                }
                else
                {
                    DiscountsListBox.SelectedIndex = removedIndex;
                }
            }
        }

        private void DiscountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveDiscountButton.Enabled = DiscountsListBox.SelectedIndex > 0;
        }

    }
}
