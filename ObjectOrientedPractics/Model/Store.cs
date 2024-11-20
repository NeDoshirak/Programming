using ObjectOrientedPractics.Model.ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет магазин, содержащий список товаров и клиентов.
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Список товаров, доступных в магазине.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Список клиентов магазина.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Получает или задает список товаров, доступных в магазине.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Получает или задает список клиентов магазина.
        /// </summary>
        public List<Customer> Customers { get; set; } = new List<Customer>();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store() { }
    }
}

