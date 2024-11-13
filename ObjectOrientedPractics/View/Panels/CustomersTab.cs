﻿using ObjectOrientedPractics.Model;
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

        private List<Customer> _customers = new List<Customer>();


        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer("---", new Address());
            _customers.Add(customer);
            CustomersListBox.Items.Add(customer);
            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        private void ClearTextBox()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                var index = CustomersListBox.SelectedIndex;
                _customers.RemoveAt(index);
                CustomersListBox.Items.RemoveAt(index);
                ClearTextBox();
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                var _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressControl.currentAddress = _currentCustomer.Address;
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
                    _customers[index].FullName = FullNameTextBox.Text;
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
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = _customers[CustomersListBox.SelectedIndex];
            }
        }

        private void AddressControl_Leave(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = _customers[CustomersListBox.SelectedIndex];
            }
        }
    }
}
