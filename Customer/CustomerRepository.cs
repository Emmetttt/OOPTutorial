using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    //Handles interaction with datastore
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId); // Collaboration
            customer.Addresslist = addressRepository.RetrieveByCustomerId(customerId).ToList();
            if (customer.CustomerId == 1)
            {
                customer.EmailAddress = "one@23.com";
                customer.FirstName = "A";
                customer.LastName = "B";
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer customer) // Collaboration
        {
            return true;
        }

    }
}
