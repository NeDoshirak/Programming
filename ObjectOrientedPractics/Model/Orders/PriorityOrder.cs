using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    internal class PriorityOrder : Order
    {
        /// <summary>
        /// gets and sets the delivery date.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// gets and sets the delivery date.
        /// </summary>
        public OrderTime DeliveryTime { get; set; }


        /// <summary>
        /// Creates a sample of an inhereted class PriorityOrder.
        /// /// <param name="status">Order status.</param>
        /// <param name="address">Address.</param>
        /// <param name="items">Items of the order.</param>
        /// <param name="deliveryDate">Delivery date.</param>
        /// /// <param name="deliveryDate">Delivery time.</param>
        /// </summary>
        public PriorityOrder(
            Address address,
            List<Item> items,
            DateTime deliveryDate,
            OrderTime deliveryTime
        ) : base(address, items)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        public PriorityOrder()
        {

        }
    }
}
