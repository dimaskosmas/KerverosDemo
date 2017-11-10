using KerverosDemo.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Entities
{
    public class EventType
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public string EventCode { get; set; }
        [MaxLength(80)]
        public string Description { get; set; }
        public EventTypeReffers ReffersTo { get; set; }

        public EventType(int id, string eventCode, string description)
        {
            Id = id;
            EventCode = eventCode;
            Description = description;
        }
        public EventType()
        {

        }
    }
}
