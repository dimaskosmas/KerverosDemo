using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Entities
{
    public class AnalyzedSignal
    {
        public Customer Customer { get; set; }
        public EventType EventType { get; set; }
        public User User { get; set; }
        public Zone Zone { get; set; }
        public Partition Partition { get; set; }
        public string SignalDescription { get; set; }

        public AnalyzedSignal(Customer customer, EventType eventType, User user, Zone zone, Partition partition)
        {
            Customer = customer;
            EventType = eventType;
            User = user;
            Zone = zone;
            Partition = partition;
        }

        public AnalyzedSignal(Customer customer, EventType eventType, Zone zone, Partition partition)
        {
            Customer = customer;
            EventType = eventType;
            Zone = zone;
            Partition = partition;
        }

        public AnalyzedSignal(Customer customer, EventType eventType, User user, Partition partition)
        {
            Customer = customer;
            EventType = eventType;
            User = user;
            Partition = partition;
        }

        public AnalyzedSignal()
        {

        }
    }
}
