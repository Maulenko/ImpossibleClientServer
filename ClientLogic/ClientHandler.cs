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
                Client.Send(new Packet(BytesTransformation.TransformIt("Test String", "Test String2", 1337, true, 412.214, 4124u), "Some packet"));
            };
            Client.OnDisconnect += (sender, tcp) =>
            {
                Console.WriteLine("Client disconnected!");
            };
            Client.OnError += (sender, error) =>
            {
                Console.WriteLine($"{error.Message}\n{error.StackTrace}");
            };
            Client.DataReceived += (sender, msg) =>
            {
                Console.WriteLine($"PacketType: {msg.GetPacket.PacketType}");
                Client.PacketHandler(msg, false);
            };
            if (!Client.Connect("127.0.0.1", 6124, TimeSpan.FromSeconds(15)))
                Console.WriteLine("Connection aborted. Timeout!");
            Console.ReadLine();
            Task.Delay(-1).Wait();
        }
    }
}
