using KerverosDemo.Receivers.Common;
using KerverosDemo.Entities;
using System;

namespace KerverosDemo.Data.Common
{
    public class SurguardMlr2 : IProtocol
    {
        public string ProtocolName => "SurguardMlr";

        public IncomingSignal DecodeInputSignal(string signal)
        {
            //TODO: Write code to decode input string
            var receivedSignal = new IncomingSignal
            {
                ReceivedAt = DateTime.Now,
                RawData = signal
            };
            var signalType = signal.Substring(0, 1);
            switch (signalType)
            {
                case "5": //CID string
                    receivedSignal.CustomerCode = signal.Substring(7, 4);
                    receivedSignal.EventCode = signal.Substring(11, 4);
                    receivedSignal.PartitionCode = signal.Substring(15, 2);
                    receivedSignal.ZoneUserCode = signal.Substring(17, 3);
                    break;

                case "4": //Caller ID
                    break;

                default:
                    break;
            }
            return receivedSignal;
        }
    }
}
