using MetaTraderConnector.Models;

namespace MetaTraderConnector.DataReceivers
{
    public class MarketDataVisualizer : IMarketDataReceiver
    {

        public bool OnInit()
        {
            System.Console.WriteLine("OnInit");
            return true;
        }

        public void OnTick(TickInfo tickInfo)
        {
            System.Console.WriteLine("OnTick");
        }
        public void OnBookEvent(BookInfo bookInfo)
        {
            System.Console.WriteLine("OnBookEvent");
        }

        public void OnDeinit()
        {
            System.Console.WriteLine("OnDeinit");
        }
    }
}