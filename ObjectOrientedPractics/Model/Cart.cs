using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Cart : ICloneable
    {
        /// <summary>
        /// Список товаров <see cref="Item"/> в корзине.
        /// </summary>
        internal List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Возвращает общую стоимость товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                // Если список товаров пустой, возвращаем 0.
                if (Items == null)
                {
                    return 0;
                }

                double total = 0;
                // Суммируем стоимость каждого товара в корзине.
                foreach (var item in Items)
                {
                    total += Convert.ToDouble(item.Cost);
                }

                return total;
            }
        }

        /// <summary>
        /// Создает глубокую копию текущей корзины.
        /// </summary>
        /// <returns>Копия текущей корзины.</returns>
        public object Clone()
        {
            var cart = new Cart();

            // Клонируем каждый товар в корзине и добавляем в новую корзину.
            foreach (var item in this.Items)
            {
                cart.Items.Add((Item)item.Clone());
            }

            return cart;
        }

    }
}
