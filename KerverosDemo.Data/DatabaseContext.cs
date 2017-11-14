using KerverosDemo.Data.EntityMaps;
using KerverosDemo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext():base("name=Default")
        {
            
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<Partition> Partitions { get; set; }
        public virtual DbSet<ReceivedSignal> ReceivedSignals { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new PartitionMap());
            modelBuilder.Configurations.Add(new ZoneMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new ReceivedSignalMap());
            modelBuilder.Configurations.Add(new EventTypeMap());
        }
    }
        
}
