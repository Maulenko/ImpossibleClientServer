using EasyTcp.Client;
using EasyTcp.Common.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Connect()
        {
            Client.OnConnected += (sender, tcp) =>
            {
                Console.WriteLine("Client successfuly connected!");
            };
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
    }
}
