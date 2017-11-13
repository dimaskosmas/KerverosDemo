using KerverosDemo.Data.Common;
using KerverosDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Data
{
    public class ZonesRepository : IZonesRepository
    {
        public Zone[] GetZones()
        {
            using (var db = new DatabaseContext())
            {
                return db.Zones.ToArray();
            }
        }
    }
}
