using KerverosDemo.Data.Common;
using KerverosDemo.Entities;
using KerverosDemo.Entities.Enums;
using KerverosDemo.Entities.Extensions;
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

        public AnalyzedSignal AnalyzeReceivedSignal(IncomingSignal signal)
        {

            using (var db = new DatabaseContext())
            {
                ReceivedSignal receivedSignal = new ReceivedSignal
                {
                    CustomerCode = signal.CustomerCode,
                    EventCode = signal.EventCode,
                    ReceivedAt = signal.ReceivedAt,
                    RawData = signal.RawData
                };
                User user = null;
                Zone zone = null;
                Partition partition = null;
                EventType eventType = null;
                //TODO: Find customer
                var customer = db.Customers
                    .Include(s=> s.Users)
                    .Include(s => s.Zones)
                    .Include(s => s.Partitions)
                    .FirstOrDefault(s => s.CustomerCode.Equals(receivedSignal.CustomerCode));
                if (customer != null)
                {
                    if (int.TryParse(signal.PartitionCode, out var p))
                    {
                        receivedSignal.PartitionCode = p;
                        //TODO: Find customer partition in db
                        if (p > 0)
                            partition = customer.Partitions.FirstOrDefault(s => s.PartitionCode == p);

                    }

                    eventType = db.EventTypes.FirstOrDefault(s => s.EventCode.Equals(receivedSignal.EventCode));
                    if (eventType != null)
                    {
                        switch (eventType.ReffersTo)
                        {
                            case EventTypeReffers.User:
                                if (int.TryParse(signal.ZoneUserCode, out var u))
                                {
                                    receivedSignal.UserCode = u;
                                    //TODO Find customer user in db
                                    if (u > 0)
                                    {
                                        user = customer.Users.FirstOrDefault(s => s.UserCode == u);
                                    }
                                }
                                break;
                            case EventTypeReffers.Zone:
                                if (int.TryParse(signal.ZoneUserCode, out var z))
                                {
                                    receivedSignal.ZoneCode = z;
                                    //TODO Find customer zone in db
                                    if(z > 0)
                                    {
                                        zone = customer.Zones.FirstOrDefault(s => s.ZoneCode == z);
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        receivedSignal.Description = eventType.Description;
                    }
                    
                }
                var analyzedSignal = new AnalyzedSignal(customer, eventType, user, zone, partition);
                analyzedSignal.SignalDescription = analyzedSignal.GetDescription();
                return analyzedSignal;
            }
        }

        //private string GetReceivedSignalDescription(AnalyzedSignal receivedSignal)
        //{
        //    var description = string.Empty;
        //    if(receivedSignal != null)
        //    description = $"{receivedSignal.EventType?.Description} {receivedSignal.Partition.Description} {receivedSignal.User?.Name} {receivedSignal.Zone?.Description}";
        //    return description;
        //}
    }
}
