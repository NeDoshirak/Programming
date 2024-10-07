using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс для представления товара
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Уникальный идентификатор товара
        /// </summary>
        public readonly int Id = IdGenerator.GetNextId;

        private string _name;
        private string _info;
        private double _cost;

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
            }
        }

        /// <summary>
        /// Конструктор для инициализации товара с названием, описанием и ценой
        /// </summary>
        /// <param name="name">Название товара</param>
        /// <param name="info">Описание товара</param>
        /// <param name="cost">Цена товара</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Пустой конструктор для инициализации товара без параметров
        /// </summary>
        public Item() { }

        /// <summary>
        /// Метод для строкового представления товара
        /// </summary>
        public override string ToString() => $"Item name: {Name} cost: {Cost}";
    }


}
