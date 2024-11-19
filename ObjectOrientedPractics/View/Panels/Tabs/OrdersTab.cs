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
    public partial class OrdersTab : UserControl
    {
        public OrdersTab()
        {
            InitializeComponent();
            AddressControl.DisableInput();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            panel1.Visible = false;
        }

        /// <summary>
        /// Возвращает и задает покупателей.
        /// </summary>
        internal List<Customer> Customers { get; set; }

        /// <summary>
        /// Возвращает список заказов.
        /// </summary>
        private List<Order> Orders { get; } = new List<Order>();

        PriorityOrder _selectedPriorityOrder = null;

        /// <summary>
        /// Обновляет данные вкладки заказов <see cref="OrdersTab"/>.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Обновляет данные таблицы заказов <see cref="OrdersDataGridView"/>.
        /// </summary>
        private void UpdateOrders()
        {
            Orders.Clear();
            OrdersDataGridView.Rows.Clear();

            foreach (var customer in Customers)
            {
                var address = $"{customer.Address.Country}, {customer.Address.City}, ";
                address += $"{customer.Address.Street} {customer.Address.Building}, ";
                address += $"{customer.Address.Apartment}";

                foreach (var order in customer.Orders)
                {
                    Orders.Add(order);
                    OrdersDataGridView.Rows.Add(
                        order.Id, order.CreationDate, order.Status, customer.FullName,
                        address, order.Amount);
                }
            }
        }

        /// <summary>
        /// Возвращает список именований товаров.
        /// </summary>
        /// <param name="items">Список товаров <see cref="List{Item}"/>.</param>
        /// <returns>Список именований товаров <see cref="List{string}"/>.</returns>
        private List<string> GetItemNames(List<Item> items)
        {
            var itemNames = new List<string>();
            foreach (var item in items)
            {
                itemNames.Add(item.Name);
            }
            return itemNames;
        }

        /// <summary>
        /// Событие при выборе другого статуса заказа.
        /// </summary>
        /// <param name="sender">Элемент управления, вызвавший событие.</param>
        /// <param name="e">Данные о событии.</param>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedCells.Count == 0)
            {
                return;
            }

            var selectedIndex = OrdersDataGridView.SelectedCells[0].RowIndex;
            Orders[selectedIndex].Status = (OrderStatus)StatusComboBox.SelectedItem;
            OrdersDataGridView[2, selectedIndex].Value =
                Enum.GetName(typeof(OrderStatus), Orders[selectedIndex].Status);
        }

        private void OrdersDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedCells.Count == 0)
            {
                IdTextBox.Text = string.Empty;
                CreatedTextBox.Text = string.Empty;
                StatusComboBox.SelectedIndex = -1;
                StatusComboBox.Enabled = false;
                AddressControl.currentAddress = null;
                OrderItemsListBox.DataSource = new List<string>();
                AmountLabel.Text = string.Empty;
                return;
            }

            var selectedIndex = OrdersDataGridView.SelectedCells[0].RowIndex;


            if (Orders[selectedIndex].GetType() == typeof(PriorityOrder))
            {
                panel1.Visible = false;
                _selectedPriorityOrder = (PriorityOrder)Orders[selectedIndex];
                DeliveryTimeComboBox.Items.Clear();
                DeliveryTimeComboBox.Items.AddRange(new String[6] { "9-11", "11-13", "13-15", "15-17", "17-19", "19-21" });
                DeliveryTimeComboBox.SelectedIndex = (int)_selectedPriorityOrder.DeliveryTime;
            

            }
            else
            {
                panel1.Visible = true;
                _selectedPriorityOrder = null;
            }

            IdTextBox.Text = Orders[selectedIndex].Id.ToString();
            CreatedTextBox.Text = Orders[selectedIndex].CreationDate.ToString();
            StatusComboBox.SelectedItem = Orders[selectedIndex].Status;
            StatusComboBox.Enabled = true;
            AddressControl.currentAddress = Orders[selectedIndex].Address;
            AddressControl.UpdateControl();
            AddressControl.DisableInput();
            OrderItemsListBox.DataSource = GetItemNames(Orders[selectedIndex].Items);
            AmountLabel.Text = Orders[selectedIndex].Amount.ToString();
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder == null)
            {
                return;
            }

            if (DeliveryTimeComboBox.SelectedItem == null)
            {
                return;
            }

            _selectedPriorityOrder.DeliveryTime = (OrderTime)DeliveryTimeComboBox.SelectedIndex;


        }

        private void DeliveryTimeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
