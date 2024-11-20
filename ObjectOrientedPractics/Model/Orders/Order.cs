using ObjectOrientedPractics.Model.ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    public class Order : IEquatable<Order>
    {
        private readonly int _id = IdGenerator.GetNextId;
        private readonly DateTime _creationDate;
        private Address _address;

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        public DateTime CreationDate
        {
            get { return _creationDate; }
        }

        /// <summary>
        /// Адрес доставки заказа.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Статус заказа.
        /// </summary>
        public OrderStatus Status { get; set; } = new OrderStatus();

        /// <summary>
        /// Общая стоимость заказа с учетом скидок.
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        /// <summary>
        /// Сумма скидки на заказ.
        /// </summary>
        public double DiscountAmount { get; }

        /// <summary>
        /// Общая сумма товаров в заказе.
        /// </summary>
        public double Amount
        {
            get
            {
                double sum = 0;
                foreach (var item in Items)
                {
                    sum += item.Cost;
                }
                return sum;
            }
        }

        /// <summary>
        /// Конструктор для инициализации заказа с адресом и списком товаров.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        public Order(Address address, List<Item> items)
        {
            Address = address;
            Items = items;
            _creationDate = DateTime.Now; // Инициализация даты создания заказа
        }

        /// <summary>
        /// Пустой конструктор для создания заказа без параметров.
        /// </summary>
        public Order() { }

        /// <summary>
        /// Сравнивает текущий экземпляр <see cref="Order"/> с другим экземпляром.
        /// </summary>
        /// <param name="other">Другой экземпляр заказа для сравнения.</param>
        /// <returns>True, если заказы равны по идентификатору; иначе - False.</returns>
        public bool Equals(Order other)
        {
            if (other == null)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            // Сравнение по уникальному идентификатору.
            return this.Id == other.Id;
        }
    }

}
