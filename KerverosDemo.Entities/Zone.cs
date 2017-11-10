using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Entities
{
    public class Zone
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(16)]
        public string CustomerCode { get; set; }

        public int ZoneCode { get; set; }
        [MaxLength(80)]
        public string Description { get; set; }

        public Zone(int id, string customerCode, int zoneCode, string description)
        {
            Id = id;
            CustomerCode = customerCode;
            ZoneCode = zoneCode;
            Description = description;
        }

        public Zone()
        {

        }
    }
}
