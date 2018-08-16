using System;
using System.Collections;
using System.Collections.Generic;
using ACME.Common;

namespace ACM.BL
{
    /*Business layer logic*/
    public class Customer : ILoggable, IEnumerable<int> //Interface inherits
    {
        public Customer()
            : this(0) // constructor chaining
        {

        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            Addresslist = new List<Address>();
        }
        public List<Address> Addresslist { get; set; } //Composition
        public static int InstanceCount { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }

        public string FullName
        {
            get
            {
                string FullName = "";
                if(!string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(FirstName))
                {
                    FullName = LastName + ", " + FirstName;
                }
                else if (!string.IsNullOrWhiteSpace(LastName))
                {
                    FullName = LastName;
                }
                else if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    FullName = FirstName;
                }
                return FullName;
            }
        }

        public bool Validate()
        {
            // Last name and email address are required
            bool isValid = true;

            if (string.IsNullOrEmpty(LastName))
            {
                isValid = false;
            }
            if (string.IsNullOrEmpty(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }

        public string Log()
        {
            //Implementation of ILoggable method
            var logString = this.CustomerId + ": " +
                            this.FullName + " " +
                            "Email: " + this.EmailAddress;
            return logString;
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
