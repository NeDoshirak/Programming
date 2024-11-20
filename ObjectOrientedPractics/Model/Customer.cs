using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс для представления клиента.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор клиента.
        /// </summary>
        public readonly int Id = IdGenerator.GetNextId;

        private string _fullname;
        private Address _address;
        private Cart _cart;
        private List<Order> _orders;

        /// <summary>
        /// Список заказов клиента.
        /// </summary>
        public List<Order> Orders { get; set; } = new List<Order>();

        /// <summary>
        /// Корзина клиента.
        /// </summary>
        public Cart Cart { get; set; } = new Cart();

        /// <summary>
        /// Указывает, является ли клиент приоритетным.
        /// </summary>
        public bool IsPriority { get; set; } = false;

        /// <summary>
        /// Список скидок, доступных клиенту.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Полное имя клиента.
        /// </summary>
        public string FullName
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "fullname");
                _fullname = value;
            }
        }

        /// <summary>
        /// Адрес клиента.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Конструктор для инициализации клиента с полным именем и адресом.
        /// </summary>
        /// <param name="fullname">Полное имя клиента.</param>
        /// <param name="address">Адрес клиента.</param>
        public Customer(string fullname, Address address)
        {
            FullName = fullname;
            Address = address;
            Discounts = new List<IDiscount>() { new PointsDiscount() };
        }

        /// <summary>
        /// Пустой конструктор для инициализации клиента без параметров.
        /// </summary>
        public Customer() { }

        /// <summary>
        /// Метод для строкового представления клиента.
        /// </summary>
        /// <returns>Строковое представление клиента.</returns>
        public override string ToString() => $"Customer name: {FullName}";
    }
}
