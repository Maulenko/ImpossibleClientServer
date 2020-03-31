using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic
{
    public static class ServerEvents
    {
        public static Action<string> Info;
        public static Action<string> Error;
        public static Action<string> Warn;
        public static Action<string> Debug;
    }
}
