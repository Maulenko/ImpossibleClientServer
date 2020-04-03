using AwwareCmds;
using AwwareCmds.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace CommandsModule.Commands
{
    public class System : ICMD
    {
        public string Name => "System";

        public string Cmd => "system";

        public string CmdAbbr => "sys";

        public string Desc => "System commands";

        public string Syntax => "";

        public List<SubInfo> Subcommands => new List<SubInfo>()
        {

        };

        public void C_Execute(Executer exe, ArgsController args, Socket client)
        {
            ServerLogic.ServerEvents.Info?.Invoke("System execute!");
            ServerLogic.MainLogic.GetInstance.SendMessage(ServerLogic.OClient.Info, "SYSTEM EXECUTED!", client);
            Thread.Sleep(5000);
            ServerLogic.ServerEvents.Info?.Invoke("System execute!!!");
        }

        public void C_Init(Executer exe)
        {
            ServerLogic.ServerEvents.Info?.Invoke("System init!");
        }
    }
}
