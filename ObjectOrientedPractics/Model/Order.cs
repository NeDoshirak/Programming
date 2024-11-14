using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Order
    {
        private readonly int _id = IdGenerator.GetNextId;
        private readonly DateTime _dataTime;
        private Address _address;
        private Cart _items;

        public DateTime DateTime { get; set; }

        public Address Address { get { return _address; } set { _address = value; } }

        public Cart Items { get; set; }

        public double Amount
        {
            get
            {
                return _items.Amount;
            }
        }
    }
}
