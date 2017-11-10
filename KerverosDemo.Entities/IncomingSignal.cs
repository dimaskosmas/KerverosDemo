using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Entities
{
    public class IncomingSignal
    {
        public string CustomerCode { get; set; }
        public DateTime ReceivedAt { get; set; }
        public string EventCode { get; set; }
        public string PartitionCode { get; set; }
        public string ZoneUserCode { get; set; }
        public string Description { get; set; }
        public string CallerId { get; set; }
        public string RawData { get; set; }
    }
}
