using ACM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public static int InstanceCount { get; set; }

        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        //public Address HomeAddress { get; set; }
        //public Address WorkAddress { get; set; }
        public List<Address> AddressList { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress{ get; set; }
        public int CustomerId { get; private set; }
        public string   FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                        fullName += ", ";
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public int CustomerType { get; set; }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public string Log()
        {
            var logString = this.CustomerId + ": " +
                                    this.FullName + " " +
                                    "Email: " + this.EmailAddress + " " +
                                    "Status: " + this.EntityState.ToString();
            return logString;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
