using System;

namespace MetaTraderConnector.Models
{
    public class TickInfo
    {
        public DateTime Time { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
        public double Last { get; set; }
        public ulong Volume { get; set; }
        public long TimeMsc { get; set; }
    }
}