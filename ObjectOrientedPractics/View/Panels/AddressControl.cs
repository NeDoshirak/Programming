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
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }

        internal Address currentAddress;

        public void UpdateControl()
        {
            if (currentAddress == null)
            {
                DisableInput();
                return;
            }
            PostIndexTextBox.Text = currentAddress.Index.ToString();
            CityTextBox.Text = currentAddress.City;
            CountryTextBox.Text = currentAddress.Country;
            StreetTextBox.Text = currentAddress.Street;
            BuildingTextBox.Text = currentAddress.Building;
            ApartmentTextBox.Text = currentAddress.Apartment;
            EnableInput();
        }

        public void DisableInput()
        {
            PostIndexTextBox.Enabled = false;
            CityTextBox.Enabled = false;
            CountryTextBox.Enabled = false;
            StreetTextBox.Enabled = false;
            BuildingTextBox.Enabled = false;
            ApartmentTextBox.Enabled = false;
        }

        public void EnableInput()
        {
            PostIndexTextBox.Enabled = true;
            CityTextBox.Enabled = true;
            CountryTextBox.Enabled = true;
            StreetTextBox.Enabled = true;
            BuildingTextBox.Enabled = true;
            ApartmentTextBox.Enabled = true;
        }

        private void PostIndexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)46) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && PostIndexTextBox.Text != "")
            {
                try
                {
                    currentAddress.Index = int.Parse(PostIndexTextBox.Text);
                }
                catch (ArgumentException err)
                {
                    PostIndexTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && PostIndexTextBox.Text == "")
            {
                PostIndexTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter postal index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PostIndexTextBox.BackColor = Color.White;
            }
        }

        private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && CountryTextBox.Text != "")
            {
                try
                {
                    var text = CountryTextBox.Text.Replace(".", ",");
                    currentAddress.Country = text;
                }
                catch (ArgumentException err)
                {
                    CountryTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && CountryTextBox.Text == "")
            {
                CountryTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CountryTextBox.BackColor = Color.White;
            }
        }

        private void CityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && CityTextBox.Text != "")
            {
                try
                {
                    var text = CityTextBox.Text.Replace(".", ",");
                    currentAddress.City = text;
                }
                catch (ArgumentException err)
                {
                    CityTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && CityTextBox.Text == "")
            {
                CityTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CityTextBox.BackColor = Color.White;
            }
        }

        private void StreetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && StreetTextBox.Text != "")
            {
                try
                {
                    var text = StreetTextBox.Text.Replace(".", ",");
                    currentAddress.Street = text;
                }
                catch (ArgumentException err)
                {
                    StreetTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && StreetTextBox.Text == "")
            {
                StreetTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter street.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StreetTextBox.BackColor = Color.White;
            }
        }

        private void BuildingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && BuildingTextBox.Text != "")
            {
                try
                {
                    var text = BuildingTextBox.Text.Replace(".", ",");
                    currentAddress.Building = text;
                }
                catch (ArgumentException err)
                {
                    BuildingTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && BuildingTextBox.Text == "")
            {
                BuildingTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter building.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BuildingTextBox.BackColor = Color.White;
            }
        }

        private void ApartmentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && ApartmentTextBox.Text != "")
            {
                try
                {
                    var text = ApartmentTextBox.Text.Replace(".", ",");
                    currentAddress.Apartment = text;
                }
                catch (ArgumentException err)
                {
                    ApartmentTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && ApartmentTextBox.Text == "")
            {
                ApartmentTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter appartment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ApartmentTextBox.BackColor = Color.White;
            }
        }

        private void AddressControl_Load(object sender, EventArgs e)
        {
            DisableInput();
        }
    }
}
