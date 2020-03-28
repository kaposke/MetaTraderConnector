namespace MetaTraderConnector.Models
{
    public class BookInfo
    {
        public int Type { get; set; }
        public double Price { get; set; }
        public long Volume { get; set; }
        public double VolumeReal { get; set; }
    }
}