using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    // Customer, order date, shipping address
    // Validate(), Retrieve(), Save()
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; } //nullable value type
        public List<OrderItem> orderItems { get; set; }


        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }

    }
}
