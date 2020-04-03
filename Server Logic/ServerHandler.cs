using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using EasyTcp.Server;

namespace ServerLogic
{
    public class ServerHandler
    {
        public EasyTcpServer Server;
        public ServerHandler()
        {
            Server = new EasyTcpServer(System.Reflection.Assembly.GetExecutingAssembly());
        }
        public void ServerStart()
        {
            ServerEvents.Info?.Invoke("Server starting...");
            Server.OnServerStarted += OnServerStarted;
            Server.ClientConnected += OnClientConnected;
            Server.ClientDisconnected += OnClientDisconnected;
            Server.DataReceived += (sender, msg) =>
            {
                Server.PacketHandler(msg, false);
            };
            Server.OnError += (sender, ex) =>
            {
                Console.WriteLine($"{ex.Message}\n{ex.StackTrace}");
            };
            Server.Start("127.0.0.1", 6124, 99999);
        }

        private void OnServerStarted(object sender, Socket e)
        {
            ServerEvents.Success?.Invoke("Server started!");
        }

        private void OnClientDisconnected(object sender, Socket e)
        {
            ServerEvents.Error?.Invoke($"Client [{e.RemoteEndPoint.ToString()}] disconnected!");
        }

        private void OnClientConnected(object sender, Socket e)
        {
            ServerEvents.Info?.Invoke($"Client [{e.RemoteEndPoint.ToString()}] connected!");
        }
    }
}
