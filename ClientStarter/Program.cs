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
        static void Main(string[] args)
        {
            Console.Title = "ImpClient v1.0";
            Init();
            ClientLogic.ClientLogic.GetInstance.Handler.TryConnect(1);
            Task.Delay(-1).Wait();
        }
        static void Init()
        {
            ClientEvents.Info += ConsoleIO.Info;
            ClientEvents.Error += ConsoleIO.Error;
            ClientEvents.Debug += ConsoleIO.Debug;
            ClientEvents.Success += ConsoleIO.Success;
            ClientEvents.Warn += ConsoleIO.Warn;
            ClientEvents.Custom += ConsoleIO.Custom;
        }
    }
}
