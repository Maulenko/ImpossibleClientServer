using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLogic
{
    public class ClientLogic
    {
        public ClientHandler Handler;
        public ClientLogic()
        {
            Handler = new ClientHandler("127.0.0.1", 6124);
        }
    }
}
