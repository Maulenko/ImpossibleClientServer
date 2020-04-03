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
    public class CommandPacket : IServerPacket
    {
        public string PacketType => "CPacket";

        public void Execute(Message msg, EasyTcpServer server)
        {
            Packet pack = msg.GetPacket;
            List<object> objs = BytesTransformation.TransformToObject(BytesCompress.Decompress(pack.RawData), typeof(string));
            ServerEvents.Debug?.Invoke($"Command Received: {objs[0].ToString()}");
            MainLogic.GetInstance.Exec.CommandHandler(objs[0].ToString(), msg.Socket);
        }
    }
}
