using EasyTcp.Client;
using EasyTcp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLogic.Packets
{
    public class AuthPackets : IClientPacket
    {
        public string PacketType => "AuthLogin";

        public void Execute(Message msg, EasyTcpClient client)
        {

        }
    }
}
