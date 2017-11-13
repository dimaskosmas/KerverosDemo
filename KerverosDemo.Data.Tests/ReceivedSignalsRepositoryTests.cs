using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using KerverosDemo.Entities;

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

        [TestMethod]
        public void GetRetrievePartitions()
        {
            var repo = new PartitionsRepository();
            var partitions = repo.GetPartitions("5000");
            Assert.IsNotNull(partitions);
            Assert.IsTrue(partitions.Any());
        }

        [TestMethod]
        public void GetRetrieveZones()
        {
            var repo = new ZonesRepository();
            var zones = repo.GetZones();
            Assert.IsNotNull(zones);
            Assert.IsTrue(zones.Any());
        }

        [TestMethod]
        public void GetRetrieveEventTypes()
        {
            var repo = new EventTypeRepository();
            var events = repo.GetEventType();
            Assert.IsNotNull(events);
            Assert.IsTrue(events.Any());
        }

        [TestMethod]
        public void CanAnalyzeSignal()
        {
            var signal = new IncomingSignal
            {
                CustomerCode = "5000",
                EventCode = "E110",
                PartitionCode = "01",
                ZoneUserCode = "1"
            };

            var repo = new ReceivedSignalsRepository();
            var result = repo.AnalyzeReceivedSignal(signal);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Customer);
        }
    }
}
