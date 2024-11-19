using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    public class Order : IEquatable<Order>
    {
        private readonly int _id = IdGenerator.GetNextId;
        private readonly DateTime _creationDate;
        private Address _address;
        public List<Item> Items { get; set; } = new List<Item>();

        public DateTime CreationDate { get; set; }

        public Address Address { get { return _address; } set { _address = value; } }

        public int Id { get { return _id; } }

        public OrderStatus Status { get; set; } = new OrderStatus();

        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        public double DiscountAmount { get; }

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

        public Order(Address address, List<Item> items)
        {
            Address = address;
            Items = items;
            CreationDate = DateTime.Now;
        }

        public Order()
        {

        }

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

            return this.Id == other.Id;
        }
    }
}
