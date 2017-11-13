namespace KerverosDemo.Data.Migrations
{
    using KerverosDemo.Entities;
    using KerverosDemo.Entities.Enums;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<KerverosDemo.Data.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Customers.AddOrUpdate(new Customer("Kosmas", "5000", "Ethnikis antistasews 79"));
            context.Customers.AddOrUpdate(new Customer("Aris", "1001", "Ethnikis antistasews 79"));
            context.SaveChanges();

            var EventTypes = new List<EventType>()
            {
                new EventType(1,"E110","Φωτιά"){ReffersTo = EventTypeReffers.Zone  },
                new EventType(2,"E401","Αφοπλισμός από χρήστη"){ReffersTo = EventTypeReffers.User },
                new EventType(3,"R110","Αποκατάσταση φωτιάς"){ReffersTo = EventTypeReffers.Zone  },
                new EventType(4,"R401","Οπλισμός από χρήστη"){ReffersTo = EventTypeReffers.User  },


            };
            EventTypes.ForEach(s => context.EventTypes.AddOrUpdate(s));
            context.SaveChanges();

            var Zones = new List<Zone>()
            {
                new Zone(1,"5000",1,"Zone 1"),
                new Zone(2,"5000",2,"Zone 2"),
                new Zone(3,"1001",1,"Zone 1"),
            };
            Zones.ForEach(s => context.Zones.AddOrUpdate(s));
            context.SaveChanges();

            var Partitions = new List<Partition>()
            {
                new Partition(1, "5000",1,"Partition 1"),
                new Partition(2, "5000",2,"Partition 2"),
                new Partition(3, "5000",3,"Partition 3"),
                new Partition(4, "5000",1,"Partition 1"),
                new Partition(5, "5000",2,"Partition 1"),
                new Partition(6, "5000",3,"Partition 1"),
                new Partition(7, "1001",1,"Partition 1"),
                new Partition(8, "1001",2,"Partition 2"),
            };
            Partitions.ForEach(s => context.Partitions.AddOrUpdate(s));
            context.SaveChanges();

            var ReceivedSignals = new List<ReceivedSignal>()
            {
                new ReceivedSignal(1,"5000",System.DateTime.Now,"E401",1,0,2,"Afoplisa","5002 185000E40101002"),
                new ReceivedSignal(1,"5000",System.DateTime.Now,"R401",1,0,2,"Oplisa","5003 185000R40101003"),
                new ReceivedSignal(1,"5000",System.DateTime.Now,"E110",0,1,2,"Fotia","5004 185000E11001002"),
                new ReceivedSignal(1,"5000",System.DateTime.Now,"R110",0,1,2,"Fotia_off","5005 185000R11001001"),
            };                                                          
            ReceivedSignals.ForEach(s => context.ReceivedSignals.AddOrUpdate());
            context.SaveChanges();


        }
    }
}
