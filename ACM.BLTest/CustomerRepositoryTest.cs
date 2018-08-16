using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "one@23.com",
                FirstName = "A",
                LastName = "B",
                Addresslist = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 3,
                        StreeLine1 = "One",
                        StreeLine2 = "Two",
                        City = "Three",
                        State = "Four",
                        PostalCode = "Five",
                        Country = "Six"
                    },
                    new Address()
                    {
                        AddressType = 3,
                        StreeLine1 = "a",
                        StreeLine2 = "b",
                        City = "c",
                        State = "d",
                        PostalCode = "e",
                        Country = "f"
                    }
                }
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(actual.EmailAddress, expected.EmailAddress);
            Assert.AreEqual(actual.FirstName, expected.FirstName);
            Assert.AreEqual(actual.LastName, expected.LastName);
            Assert.AreEqual(actual.CustomerId, expected.CustomerId);
        }
    }
}
