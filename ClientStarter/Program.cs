using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientLogic;

namespace ClientStarter
{
    class Program
    {
        public static ClientLogic.ClientLogic logic;
        static void Main(string[] args)
        {
            Init();
            logic.Handler.TryConnect(5);
            Task.Delay(-1).Wait();
        }
        static void Init()
        {
            logic = new ClientLogic.ClientLogic();
            ClientEvents.Info += ConsoleIO.Info;
            ClientEvents.Error += ConsoleIO.Error;
            ClientEvents.Debug += ConsoleIO.Debug;
            ClientEvents.Success += ConsoleIO.Success;
            ClientEvents.Warn += ConsoleIO.Warn;
            ClientEvents.Custom += ConsoleIO.Custom;
        }
    }
}
