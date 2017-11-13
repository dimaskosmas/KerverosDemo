using KerverosDemo.Data.Common;
using KerverosDemo.Entities;
using System.Linq;

namespace KerverosDemo.Data
{
    public class EventTypeRepository : IEventTypeRepository
    {
        public EventType[] GetEventType()
        {
            using (var db = new DatabaseContext())
            {
                return db.EventTypes.ToArray();
            }
        }
    }
}
