﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            EasyTcpServer server = new EasyTcpServer(System.Reflection.Assembly.GetExecutingAssembly());
            server.OnServerStarted += (sender, s) =>
            {
                ServerEvents.Info?.Invoke("Server started!");
            };
            server.ClientConnected += (sender, client) =>
            {
                ServerEvents.Info?.Invoke($"Client [{client.RemoteEndPoint.ToString()}] connected!");
            };
            server.ClientDisconnected += (sender, client) =>
            {
                ServerEvents.Error?.Invoke($"Client [{client.RemoteEndPoint.ToString()}] disconnected!");
            };
            server.DataReceived += (sender, msg) =>
            {
                Console.WriteLine($"PacketType: {msg.GetPacket.PacketType}");
                server.PacketHandler(msg, false);
            };
            server.OnError += (sender, ex) =>
            {
                Console.WriteLine($"{ex.Message}\n{ex.StackTrace}");
            };
            server.Start("127.0.0.1", 6124, 10);
            Task.Delay(-1).Wait();
        }
    }
}
