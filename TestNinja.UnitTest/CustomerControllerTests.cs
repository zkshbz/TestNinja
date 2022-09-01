using System;
using System.Collections.Generic;
using System.Linq;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _customerController;
        [SetUp]
        public void SetUp()
        {
            _customerController = new CustomerController();
        }
        [Test]
        public void GetCustomer_IdEqualToZero_ReturnNotFound()
        {
            var result = _customerController.GetCustomer(0);
            
            Assert.That(result, Is.TypeOf<NotFound>());

        }
        [Test]
        public void GetCustomer_IdNotEqualToZero_ReturnOk()
        {
            var result = _customerController.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());

        }
    }
}