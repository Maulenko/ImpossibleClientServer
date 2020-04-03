using AwwareCmds;
using AwwareCmds.Arguments;
using EasyTcp.Common.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsModule.Commands
{
    public class Auth : ICMD
    {
        public string Name => "Auth";

        public string Cmd => "auth";

        public string CmdAbbr => "a";

        public string Desc => "Authorization";

        public string Syntax => "null";

        public List<SubInfo> Subcommands => new List<SubInfo>()
        {

        };

        public void C_Execute(Executer exe, ArgsController args)
        {
            if(!ClientLogic.ClientLogic.GetInstance.Handler.Client.IsConnected)
            {
                ClientEvents.Error?.Invoke("Client doesn't connected!");
                return;
            }
            if (args.SubCmds.IsSubcmd(0, "login"))
            {
                string login = string.IsNullOrEmpty(args.StrArgs[0]) ? throw new ArgumentNullException("login") : args.StrArgs[0];
                string password = string.IsNullOrEmpty(args.StrArgs[1]) ? throw new ArgumentNullException("password") : args.StrArgs[1];
                ClientLogic.ClientLogic.GetInstance.Handler.Client.Send(BytesCompress.CompressPacket(BytesTransformation.TransformIt(login, password), "Auth"));
            }
            else if(args.SubCmds.IsSubcmd(0, "register") || args.SubCmds.IsSubcmd(0, "reg"))
            {

            }
        }

        public void C_Init(Executer exe)
        {
            
        }
    }
}
