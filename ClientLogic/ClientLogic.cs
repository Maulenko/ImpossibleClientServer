using AwwareCmds;
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
        public Executer Exec;
        public bool LockReadLine = false;
        private ClientLogic()
        {
            Handler = new ClientHandler("127.0.0.1", 6124);
            Exec = new Executer(true, "modules");
            Exec.AttachModulesFromFolder();
            AEvents.CommandBeforeStart += () => LockReadLine = true;
            AEvents.OnCommandEnded += () => LockReadLine = false;
        }
        public void CommandListener()
        {
            while (true)
            {
                if (LockReadLine)
                    continue;
                Console.Write("> ");
                Exec.CommandHandler(Console.ReadLine());
                Thread.Sleep(50);
            }
        }
        public static ClientLogic GetInstance { get { return Instance; } }
    }
}
