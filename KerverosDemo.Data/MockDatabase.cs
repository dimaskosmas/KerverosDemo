using KerverosDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KerverosDemo.Entities.Enums;

namespace KerverosDemo.Data
{
    public class MockDatabase
    {
        public List<EventType> EventTypes { get; set; }

        public MockDatabase()
        {
            GenerateMockEntries();
        }

        private void GenerateMockEntries()
        {
            EventTypes = new List<EventType>()
            {
                new EventType(1,"E110","Φωτιά"){ReffersTo = EventTypeReffers.Zone },
                new EventType(2,"E401","Αφοπλισμός από χρήστη"){ReffersTo = EventTypeReffers.User }
            };
        }
    }
}
