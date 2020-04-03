using EasyTcp.Client;
using EasyTcp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLogic.Packets
{
    public class LockReadCommand : IClientPacket
    {
        public string PacketType => "LCMD";

        public void Execute(Message msg, EasyTcpClient client)
        {
            ClientEvents.Debug?.Invoke($"BOOL: {BitConverter.ToBoolean(msg.GetPacket.RawData, 0)}");
            ClientLogic.GetInstance.LockReadLine = BitConverter.ToBoolean(msg.GetPacket.RawData, 0);
        }
    }
}
