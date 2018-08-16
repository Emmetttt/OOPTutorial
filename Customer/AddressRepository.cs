using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 3;
                address.StreeLine1 = "One";
                address.StreeLine2 = "Two";
                address.City = "Three";
                address.State = "Four";
                address.PostalCode = "Five";
                address.Country = "Six";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 3,
                StreeLine1 = "One",
                StreeLine2 = "Two",
                City = "Three",
                State = "Four",
                PostalCode = "Five",
                Country = "Six"
            };

            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 3,
                StreeLine1 = "a",
                StreeLine2 = "b",
                City = "c",
                State = "d",
                PostalCode = "e",
                Country = "f"
            };
            addressList.Add(address);

            return addressList;
        }
    }
}
