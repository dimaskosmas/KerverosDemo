using KerverosDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Receivers.Common
{
    public interface IProtocol
    {
        string ProtocolName { get; }
        IncomingSignal DecodeInputSignal(string signal);
    }
}
