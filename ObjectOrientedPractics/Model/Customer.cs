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
    /// Класс для представления клиента
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        public readonly int Id = IdGenerator.GetNextId;

        private string _fullname;
        private Address _address;
        private Cart _cart;
        private List<Order> _orders;

        public List<Order> Orders { get; set; } = new List<Order>();

        public Cart Cart { get; set; } = new Cart();

        /// <summary>
        /// Полное имя клиента
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
        /// Адрес клиента
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
        /// Конструктор для инициализации клиента с полным именем и адресом
        /// </summary>
        /// <param name="fullname">Полное имя клиента</param>
        /// <param name="address">Адрес клиента</param>
        public Customer(string fullname, Address address)
        {
            FullName = fullname;
            Address = address;
        }

        /// <summary>
        /// Пустой конструктор для инициализации клиента без параметров
        /// </summary>
        public Customer() { }

        /// <summary>
        /// Метод для строкового представления клиента
        /// </summary>
        public override string ToString() => $"Customer name: {FullName}";
    }

}
