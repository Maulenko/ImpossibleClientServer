using AwwareCmds;
using AwwareCmds.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void C_Execute(Executer exe, ArgsController args)
        {
            ClientEvents.Info?.Invoke("System execute!");
            Thread.Sleep(5000);
            ClientEvents.Info?.Invoke("System execute!!!");
        }

        public void C_Init(Executer exe)
        {
            ClientEvents.Info?.Invoke("System init!");
        }
    }
}
