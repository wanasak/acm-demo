using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepositoy
    {
        private AddressRepository addressRepositry { get; set; }

        public CustomerRepositoy()
        {
            addressRepositry = new AddressRepository();
        }

        public Customer Retrive(int customerId)
        {
            var customer = new Customer(customerId);
            customer.AddressList = addressRepositry.RetriveByCustomerId(customerId).ToList();

            if (customerId == 1)
            {
                customer.FirstName = "Bilbo";
                customer.LastName = "Baggins";
                customer.EmailAddress = "abc@gmail.com";
            }

            return customer;
        }

        public List<Customer> Retrive()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
