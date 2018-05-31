using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepositoy
    {
        public Customer Retrive(int customerId)
        {
            var customer = new Customer(customerId);

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
