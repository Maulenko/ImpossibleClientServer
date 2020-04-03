using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwwareCmds;
using EasyTcp.Common.Packets;
using EasyTcp.Server;

namespace ServerLogic
{
    public class MainLogic
    {
        public ServerHandler Handler;
        private static readonly MainLogic Instance = new MainLogic();
        public Executer Exec;
        private MainLogic()
        {
            Handler = new ServerHandler();
            Exec = new Executer(true, "modules");
            Exec.AttachModulesFromFolder();
            AEvents.OnCommandEnded += (client) => {
                ServerEvents.Info?.Invoke($"Unlock readline! [{client.RemoteEndPoint}]");
                Handler.Server.Send(client, new Packet(BitConverter.GetBytes(false), "LCMD"));
                
                };
        }        
        public void ServerStart()
        {
            Handler.ServerStart();
        }
        public static MainLogic GetInstance { get { return Instance; } }
    }
}
