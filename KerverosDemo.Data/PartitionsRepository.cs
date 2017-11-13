using KerverosDemo.Data.Common;
using KerverosDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Data
{
    public class PartitionsRepository : IPartitionsRepository
    {
        public Partition[] GetPartitions(string customerCode)
        {
            using (var db = new DatabaseContext())
            {
                return db.Partitions.Where(s=>s.CustomerCode.Equals(customerCode)).ToArray();
            }
        }
    }
}
