using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Entities
{
    public class Partition
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(60)]
        public string CustomerCode { get; set; }
        public int ZoneCode { get; set; }
        public int PartitionCode { get; set; }
        [MaxLength(80)]
        public string Description { get; set; }

        public Partition(int id, string customerCode, int zoneCode, int partitionCode, string description)
        {
            Id = id;
            CustomerCode = customerCode;
            ZoneCode = zoneCode;
            PartitionCode = partitionCode;
            Description = description;
        }

        public Partition()
        {

        }
    }
}
