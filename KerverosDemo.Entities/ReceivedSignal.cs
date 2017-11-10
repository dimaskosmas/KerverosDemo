using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Entities
{
    public class ReceivedSignal
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(16)]
        public string CustomerCode { get; set; }
        public DateTime ReceivedAt { get; set; }
        [MaxLength(10)]
        public string EventCode { get; set; }
        public int PartitionCode { get; set; }
        public int ZoneCode { get; set; }
        public int UserCode { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        public string RawData { get; set; }

        public ReceivedSignal(int id, string customerCode, DateTime receivedAt, string eventCode, int partitionCode, int zoneCode, int userCode, string description, string rawData)
        {
            Id = id;
            CustomerCode = customerCode;
            ReceivedAt = receivedAt;
            EventCode = eventCode;
            PartitionCode = partitionCode;
            ZoneCode = zoneCode;
            UserCode = userCode;
            Description = description;
            RawData = rawData;
        }

        public ReceivedSignal()
        {

        }
    }
}
