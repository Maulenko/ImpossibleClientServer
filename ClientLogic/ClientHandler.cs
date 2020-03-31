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
        public ClientHandler()
        {
            Client = new EasyTcpClient(System.Reflection.Assembly.GetExecutingAssembly());
        }
        public void EventLoading()
        {
            Client.OnConnected += EventConnected;
            Client.OnDisconnect += (sender, tcp) =>
            {
                Console.WriteLine("Client disconnected!");
            };
            Client.OnError += (sender, error) =>
            {
                ClientEvents.Error?.Invoke($"{error.Message}\n{error.StackTrace}");
            };
            Client.DataReceived += (sender, msg) =>
            {
                Client.PacketHandler(msg, false);
            };
        }

        private void EventConnected(object sender, Socket e)
        {
            ClientEvents.Success("Client connected");
        }
    }
}
