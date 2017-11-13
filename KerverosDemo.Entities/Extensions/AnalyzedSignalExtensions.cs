using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Entities.Extensions
{
    public static class AnalyzedSignalExtensions
    {
        public static string GetDescription(this AnalyzedSignal signal)
        {
            var description = string.Empty;
            if (signal != null)
                description = $"{signal.EventType?.Description} {signal.Partition.Description} {signal.User?.Name} {signal.Zone?.Description}";
            return description;
        }
    }
}
