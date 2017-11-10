using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace KerverosDemo.Data.Tests
{
    [TestClass]
    public class ReceivedSignalsRepositoryTests
    {
        [TestMethod]
        public void GetRetrieveCustomers()
        {
            var repo = new CustomersRepository();
            var customers = repo.GetCustomers();
            Assert.IsNotNull(customers);
            Assert.IsTrue(customers.Any());
        }
    }
}
