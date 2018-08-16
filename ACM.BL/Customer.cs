using System;

namespace ACM.BL
{
    /*Business layer logic*/
    public class Customer
    {
        private string _firstName;
        private string _lastName;
        private string _emailAddress;
        private int _customerId;

        public string LastName { get; set; }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
    }
}
