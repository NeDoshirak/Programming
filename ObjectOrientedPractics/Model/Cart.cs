using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if (Items == null)
                {
                    return 0;
                }

                double total = 0;
                foreach (var item in Items)
                {
                    total += Convert.ToDouble(item.Cost);
                }

                return total;
            }
        }

        public object Clone()
        {
            var cart = new Cart();

            foreach (var item in this.Items)
            {
                cart.Items.Add((Item)item.Clone());
            }

            return cart;
        }
    }
}
