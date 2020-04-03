using AwwareCmds;
using EasyTcp.Common.Packets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientLogic
{
    public class ClientLogic
    {
        public ClientHandler Handler;
        private static readonly ClientLogic Instance = new ClientLogic();
        public bool LockReadLine { get; set; } = false;
        private ClientLogic()
        {
            Handler = new ClientHandler("127.0.0.1", 6124);
            Handler.EventLoading();
            //AEvents.CommandBeforeStart += () => LockReadLine = true;
            //AEvents.OnCommandEnded += () => LockReadLine = false;
        }
        public void CommandListener()
        {
            while (true)
            {
                if (LockReadLine)
                    continue;
                Console.Write("> ");
                string cmd = Console.ReadLine();
                if (!string.IsNullOrEmpty(cmd))
                {
                    Handler.Client.Send(BytesCompress.CompressPacket(BytesTransformation.TransformIt(cmd), "CPacket"));
                    LockReadLine = true;
                }
                Thread.Sleep(50);
            }
        }
        public static ClientLogic GetInstance { get { return Instance; } }
    }
}
