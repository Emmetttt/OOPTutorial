using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    //product, quanitity, purchase price
    //Validate(), Retrieve(), Save()
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; private set; }
        public decimal? PurchasePrice { get; private set; }
        public int ProductId { get; private set; }


        public OrderItem Retrieve(int productId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (PurchasePrice == null || OrderQuantity <= 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
