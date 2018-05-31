using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetriveExiting()
        {
            // Arrange
            var customerRepository = new CustomerRepositoy();
            var expected = new Customer(1)
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                EmailAddress = "abc@gmail.com"
            };

            // Act
            var actual = customerRepository.Retrive(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}
