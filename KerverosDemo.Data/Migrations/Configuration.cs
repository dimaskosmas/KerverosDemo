namespace KerverosDemo.Data.Migrations
{
    using KerverosDemo.Entities;
    using KerverosDemo.Entities.Enums;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KerverosDemo.Data.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KerverosDemo.Data.DatabaseContext context)
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
                new EventType(2,"E401","Αφοπλισμός από χρήστη"){ReffersTo = EventTypeReffers.User }
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
        }
    }
}
