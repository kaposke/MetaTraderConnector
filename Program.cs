using System;
using System.Collections.Generic;
using MetaTraderConnector.DataReceivers;
using MetaTraderConnector.Models;
using NetMQ;
using NetMQ.Sockets;
using Newtonsoft.Json;

namespace MetaTraderConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new MetaTraderDataProvider();
            provider.DataReceivers.Add(new MarketDataVisualizer());
            
            provider.Run();
        }
    }
}
