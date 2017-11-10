using KerverosDemo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Data
{
    class DatabaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Partition> Partitions { get; set; }
        public DbSet<ReceivedSignal> ReceivedSignals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Zone> Zones { get; set; }

    }
}
