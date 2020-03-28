using MetaTraderConnector.Models;

namespace MetaTraderConnector.DataReceivers
{
    public interface IMarketDataReceiver
    {
         bool OnInit();
         void OnTick(TickInfo tickInfo);
         void OnBookEvent(BookInfo bookInfo);
         void OnDeinit();
    }
}