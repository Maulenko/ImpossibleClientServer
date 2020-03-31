using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLogic
{
    public class ClientLogic
    {
        public ClientLogic()
        {
            ClientEvents.Debug?.Invoke("DEBUG");
            ClientEvents.Info?.Invoke("INFOqwe");
            ClientEvents.Warn?.Invoke("WARN");
            ClientEvents.Error?.Invoke("ERROR");
            ClientEvents.Success?.Invoke("SUCCESS");
            ClientEvents.Custom?.Invoke("CUSTOM", "CUSTOM", "#CA35D3");
        }
    }
}
