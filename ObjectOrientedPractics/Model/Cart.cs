using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Cart
    {
        private List<Item> _productList;

        public List<Item> ProductList { get; set; } = new List<Item>();

        public double Amount
        {
            get
            {
                double sumValue = 0;
                if (ProductList != null && ProductList.Count > 0)
                {
                    foreach (var item in _productList)
                    {
                        sumValue += item.Cost;
                    }
                    return sumValue;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
