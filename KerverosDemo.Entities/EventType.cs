using KerverosDemo.Entities.Enums;

namespace KerverosDemo.Entities
{
    public class EventType
    {
        public int Id { get; set; }
        public string EventCode { get; set; }
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
