using EasyTcp.Client;
using EasyTcp.Common;
using EasyTcp.Common.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLogic.Packets
{
    public class OutputPacket : IClientPacket
    {
        public string PacketType => "OPacket";

        public void Execute(Message msg, EasyTcpClient client)
        {
            Packet packet = msg.GetPacket;
            List<object> Objs = BytesTransformation.TransformToObject(BytesCompress.Decompress(packet.RawData), typeof(int), typeof(string));
            int mode = (int)Objs[0];
            string text = Objs[1].ToString();
            if(string.IsNullOrEmpty(text))
            {
                ClientEvents.Error?.Invoke("Text is null or empty!");
                return;
            }
            switch (mode)
            {
                case 0:
                    ClientEvents.Debug?.Invoke(text);
                    break;
                case 1:
                    ClientEvents.Info?.Invoke(text);
                    break;
                case 2:
                    ClientEvents.Success?.Invoke(text);
                    break;
                case 3:
                    ClientEvents.Warn?.Invoke(text);
                    break;
                case 4:
                    ClientEvents.Error?.Invoke(text);
                    break;
                default:
                    ClientEvents.Warn?.Invoke($"Unk|{text}");
                    break;
            }
        }
    }
}
