using EasyTcp.Client;
using EasyTcp.Common.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientLogic
{
    public class ClientHandler
    {
        public EasyTcpClient Client;
        public string IP { get; }
        public ushort Port { get; }
        public ClientHandler(string ip, ushort port) => (Client, IP, Port) = (new EasyTcpClient(System.Reflection.Assembly.GetExecutingAssembly()), ip, port);
        public void EventLoading()
        {
            Client.OnConnected += EventConnected;
            Client.OnDisconnect += EventDisconnected;
            Client.OnError += (sender, error) =>
            {
                ClientEvents.Error?.Invoke($"{error.Message}\n{error.StackTrace}");
            };
            Client.DataReceived += (sender, msg) =>
            {
                Client.PacketHandler(msg, false);
            };
        }

        public void TryConnect(int maxCount = 5)
        {
            Task TaskConnect = new Task(() =>
            {
                int count = 0;
                while (!Client.IsConnected && !(count >= maxCount))
                {
                    Client.Connect(IP, Port, TimeSpan.FromSeconds(5));
                    ClientEvents.Info?.Invoke($"Connecting {count}/{maxCount}");
                    Task.Delay(100).Wait();
                    count++;
                }
            });
            TaskConnect.ContinueWith((task) =>
            {
                if (!Client.IsConnected)
                {
                    ClientEvents.Error?.Invoke("Server no response.");
                }
            });
            TaskConnect.Start();
        }
        
        private void EventDisconnected(object sender, Socket e)
        {
            ClientEvents.Warn?.Invoke("Client disconnected");
        }

        private void EventConnected(object sender, Socket e)
        {
            ClientEvents.Success?.Invoke("Client connected");
        }
    }
}
