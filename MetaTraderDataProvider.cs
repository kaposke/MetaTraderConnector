using System;
using System.Collections.Generic;
using MetaTraderConnector.DataReceivers;
using NetMQ;
using NetMQ.Sockets;

namespace MetaTraderConnector
{
    public class MetaTraderDataProvider
    {
        public List<IMarketDataReceiver> DataReceivers { get; private set; }
        public bool Running { get; set; }

        private SubscriberSocket socket;

        public MetaTraderDataProvider()
        {
            DataReceivers = new List<IMarketDataReceiver>();
            Running = true;

            socket = new SubscriberSocket();
        }

        public void Run()
        {
            Init();

            pollMarketData();

            Deinit();
        }

        private void Init()
        {
            foreach (var receiver in DataReceivers)
            {
                receiver.OnInit();
            }
        }

        private void pollMarketData()
        {
            socket = new SubscriberSocket();
            socket.Connect("tcp://127.0.0.1:5556");
            socket.SubscribeToAnyTopic();
            socket.ReceiveReady += PrintMessage;

            while(Running)
                socket.Poll();
        }

        int count = 0;
        private void PrintMessage(object sender, NetMQSocketEventArgs args)
        {
            System.Console.WriteLine(count++);
        }

        private void Deinit()
        {
            foreach (var receiver in DataReceivers)
            {
                receiver.OnDeinit();
            }
            socket.Dispose();
        }
    }
}