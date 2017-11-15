using KerverosDemo.Entities;

namespace KerverosDemo.Receivers.Common
{
    public interface IProtocol
    {
        string ProtocolName { get; }
        IncomingSignal DecodeInputSignal(string signal);
    }
}
