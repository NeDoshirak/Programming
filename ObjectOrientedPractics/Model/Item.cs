using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс для представления товара
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        public readonly int Id = IdGenerator.GetNextId;
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Событие при обновлении <see cref="Cost"/> объекта <see cref="Item"/>.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Событие при обновлении <see cref="Name"/> объекта <see cref="Item"/>.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;

        /// <summary>
        /// Событие при обновлении <see cref="Info"/> объекта <see cref="Item"/>.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;

        /// <summary>
        /// Название товара
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "name");
                _name = value;
                NameChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Описание товара
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, "info");
                _info = value;
                InfoChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Цена товара
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, "cost");
                _cost = value;
                CostChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public Category Category { get; set; }

        /// <summary>
        /// Конструктор для инициализации товара с названием, описанием и ценой
        /// </summary>
        /// <param name="name">Название товара</param>
        /// <param name="info">Описание товара</param>
        /// <param name="cost">Цена товара</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        public Item(Item item)
        {
            Name = item.Name;
            Info = item.Info;
            Cost = item.Cost;
            Category = item.Category;
        }

        /// <summary>
        /// Пустой конструктор для инициализации товара без параметров
        /// </summary>
        public Item() { }

        /// <summary>
        /// Метод для строкового представления товара
        /// </summary>
        public override string ToString() => $"Item name: {Name} cost: {Cost}";

        public object Clone()
        {
            var item = new Item();
            item.Name = this.Name;
            item.Info = this.Info;
            item.Cost = this.Cost;
            item.Category = this.Category;
            return item;
        }

        public bool Equals(Item other)
        {
            if (other == null)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Id == other.Id;
        }

        public int CompareTo(Item other)
        {
            if (this.Cost == other.Cost)
            {
                return 0;
            }
            else if (this.Cost > other.Cost)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }


}
