using KerverosDemo.Entities.Enums;
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
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public DateTime ReceivedAt { get; set; }
        public string EventCode { get; set; }
        public int PartitionCode { get; set; }
        public int? ZoneCode { get; set; }
        public int? UserCode { get; set; }
        public string Description { get; set; }
        public string RawData { get; set; }
        public EventTypeReffers ReffersTo { get; set; }

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
