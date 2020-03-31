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
        public static MainLogic LOGIC;
        static void Main(string[] args)
        {
            Initialize();
            LOGIC.StartServer();
            Console.Read();
        }
        static void Initialize()
        {
            LOGIC = new MainLogic();
            ServerEvents.Info += ConsoleIO.Info;
        }
    }
}
