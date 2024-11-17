using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Store
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();

        public List<Item> Items { get; set; } = new List<Item>();
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public Store() { }
    }
}
