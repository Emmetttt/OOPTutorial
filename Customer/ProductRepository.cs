using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product_Repository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            Object myobject = new object();
            Console.WriteLine("Object: " + myobject.ToString());
            Console.WriteLine("Product: " + product.ToString());

            if (productId == 2)
            {
                product.CurrentPrice = 3;
                product.ProductName = "Coke";
                product.Description = "Cold beverage";
            }

            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
