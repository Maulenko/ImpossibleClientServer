using EasyTcp.Common;
using EasyTcp.Common.Packets;
using EasyTcp.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Packets
{
    public class AuthPackets : IServerPacket
    {
        public string PacketType => "Auth";

        public void Execute(Message msg, EasyTcpServer server)
        {
            Console.WriteLine($"Received packet!");
            Packet pack = msg.GetPacket;
            List<object> Objects = BytesTransformation.TransformToObject(BytesCompress.Decompress(pack.RawData), typeof(string), typeof(string));
            Console.WriteLine($"LOGIN: {Objects[0].ToString()} | PASSWORD: {Objects[1].ToString()}");
        }
    }
}
