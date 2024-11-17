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
        private readonly DateTime _creationDate = DateTime.Now;
        private Address _address;
        public List<Item> Items { get; set; } = new List<Item>();

        public DateTime CreationDate { get; set; }

        public Address Address { get { return _address; } set { _address = value; } }

        public int Id { get { return _id; } }

        public OrderStatus Status { get; set; }

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

        public Order(OrderStatus status, Address address, List<Item> items)
        {
            Status = status;
            Address = address;
            Items = items;
        }
    }
}
