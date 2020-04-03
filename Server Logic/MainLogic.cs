using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyTcp.Server;

namespace ServerLogic
{
    public class MainLogic
    {
        public ServerHandler Handler;
        private static readonly MainLogic Instance = new MainLogic();
        private MainLogic()
        {
            Handler = new ServerHandler();
        }        
        public void ServerStart()
        {
            Handler.ServerStart();
        }
        public static MainLogic GetInstance { get { return Instance; } }
    }
}
