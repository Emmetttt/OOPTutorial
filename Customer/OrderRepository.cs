using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderID)
        {
            var order = new Order(orderID);
            if (orderID == 3)
            {
                order.OrderDate = new DateTimeOffset(2015, 3, 5, 2, 4, 5, TimeSpan.Zero);
            }

            return order;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            // code that retreives the defined order fields.
            return new OrderDisplay();
        }

        public bool Save()
        {
            return true;
        }
    }
}
