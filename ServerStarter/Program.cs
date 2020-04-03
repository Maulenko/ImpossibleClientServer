using ServerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize();
            MainLogic.GetInstance.ServerStart();
            Task.Delay(-1).Wait();
        }
        static void Initialize()
        {
            ServerEvents.Info += ConsoleIO.Info;
            ServerEvents.Success += ConsoleIO.Success;
            ServerEvents.Warn += ConsoleIO.Warn;
            ServerEvents.Error += ConsoleIO.Error;
            ServerEvents.Debug += ConsoleIO.Debug;
            ServerEvents.Custom += ConsoleIO.Custom;
        }
    }
}
