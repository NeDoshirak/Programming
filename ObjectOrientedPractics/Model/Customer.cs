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
    class Customer
    {
        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        public readonly int Id = IdGenerator.GetNextId;

        private string _fullname;
        private string _address;

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
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, "address");
                _address = value;
            }
        }

        /// <summary>
        /// Конструктор для инициализации клиента с полным именем и адресом
        /// </summary>
        /// <param name="fullname">Полное имя клиента</param>
        /// <param name="address">Адрес клиента</param>
        public Customer(string fullname, string address)
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
        public override string ToString() => $"Customer name: {FullName} address: {Address}";
    }

}
