using System;

namespace ACM.BL
{
    /*
     * build a customer management system. Track !customer! name, email and home and work address.
     * track !product! name, description, current price.
     * accept orders online, track customer, order date, shipping address, products !ordered!
     * 
     * Need base class for customer, product and order.
     * How do things change over TIME?
     * Customer
     *      track name, email, home, work address
     *      Validate(), Retrieve(), Save()
     * Product
     *      track product name, description, current price
     *      Validate(), Retrieve(), Save()
     * Order
     *      Customer, order date, shipping address
     *      Validate(), Retrieve(), Save()
     * Order item
     *      product, quanitity, purchase price
     *      Validate(), Retrieve(), Save()
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
