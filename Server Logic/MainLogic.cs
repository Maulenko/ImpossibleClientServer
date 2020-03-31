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
        public MainLogic()
        {
            ServerEvents.Debug?.Invoke("DEBUG");
            ServerEvents.Info?.Invoke("INFO");
            ServerEvents.Warn?.Invoke("WARN");
            ServerEvents.Error?.Invoke("ERROR");
            ServerEvents.Success?.Invoke("SUCCESS");
            ServerEvents.Custom?.Invoke("CUSTOM", "CUSTOM", "#CA35D3");
        }        
        public void ServerStart()
        {

        }
    }
}
