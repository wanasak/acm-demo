﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrive(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Moddle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetriveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            var address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Moddle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Moddle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save()
        {
            return true;
        }
    }
}
