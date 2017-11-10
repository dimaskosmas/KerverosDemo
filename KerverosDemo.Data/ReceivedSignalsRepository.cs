using KerverosDemo.Data.Common;
using KerverosDemo.Entities;
using KerverosDemo.Entities.Enums;
using System.Data.Entity;
using System.Linq;

namespace KerverosDemo.Data
{
    public class ReceivedSignalsRepository : IReceivedSignalsRepository
    {
        private DbContext ctx;
        //Testing only
        public ReceivedSignalsRepository(DbContext ctx)
        {
            this.ctx = ctx;
        }

        public ReceivedSignalsRepository()
        {

        }

        public ReceivedSignal AnalyzeReceivedSignal(IncomingSignal signal)
        {
            var db = new MockDatabase();
            ReceivedSignal receivedSignal = new ReceivedSignal();
            receivedSignal.CustomerCode = signal.CustomerCode;
            receivedSignal.EventCode = signal.EventCode;
            receivedSignal.ReceivedAt = signal.ReceivedAt;
            receivedSignal.RawData = signal.RawData;
            if(int.TryParse(signal.PartitionCode,out var p))
            {
                receivedSignal.PartitionCode = p;
                //TODO: Find customer partition in db
            }
            var eventType = db.EventTypes.FirstOrDefault(s => s.EventCode.Equals(receivedSignal.EventCode));
            if(eventType != null)
            {
                switch (eventType.ReffersTo)
                {
                    case EventTypeReffers.User:
                        if (int.TryParse(signal.ZoneUserCode, out var u))
                        {
                            receivedSignal.UserCode = u;
                            //TODO Find customer user in db
                        }
                        break;
                    case EventTypeReffers.Zone:
                        if (int.TryParse(signal.ZoneUserCode, out var z))
                        {
                            receivedSignal.ZoneCode = z;
                            //TODO Find customer zone in db
                        }
                        break;
                    default:
                        break;
                }
                receivedSignal.Description = eventType.Description;
            }
            return receivedSignal;
        }
    }
}
