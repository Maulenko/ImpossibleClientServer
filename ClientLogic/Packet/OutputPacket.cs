using EasyTcp.Client;
using EasyTcp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLogic.Packet
{
    public class OutputPacket : IClientPacket
    {
        public string PacketType => "OPacket";

        public void Execute(Message msg, EasyTcpClient client)
        {

        }
    }
}
