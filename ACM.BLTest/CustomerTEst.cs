using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            //Act
            //Assert
            Customer customer = new Customer(); // New instance of the class
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";
            Assert.AreEqual(customer.FullName, expected);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            //Act
            //Assert
            Customer customer = new Customer(); // New instance of the class
            customer.LastName = "Baggins";

            string expected = "Baggins";
            Assert.AreEqual(customer.FullName, expected);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            //Act
            //Assert
            Customer customer = new Customer(); // New instance of the class
            customer.FirstName = "Bilbo";

            string expected = "Bilbo";
            Assert.AreEqual(customer.FullName, expected);
        }
        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Biblo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            Assert.AreEqual(Customer.InstanceCount, 3);
        }

        [TestMethod]
        public void ValidateNoEmail()
        {
            var c1 = new Customer();
            c1.EmailAddress = "";
            c1.FirstName = "A";
            c1.LastName = "B";

            Assert.AreEqual(c1.Validate(), false);
        }

        [TestMethod]
        public void ValidateNoLastName()
        {
            var c1 = new Customer();
            c1.EmailAddress = "abd@123.com";
            c1.FirstName = "A";
            c1.LastName = "";

            Assert.AreEqual(c1.Validate(), false);
        }

        [TestMethod]
        public void ValidateFull()
        {
            var c1 = new Customer();
            c1.EmailAddress = "abd@123.com";
            c1.FirstName = "A";
            c1.LastName = "C";

            Assert.AreEqual(c1.Validate(), true);
        }
    }
}
