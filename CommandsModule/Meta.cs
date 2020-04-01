using AwwareCmds;
using AwwareCmds.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsModule
{
    public class Meta : IModuleInfo
    {
        public ModuleKind Kind => ModuleKind.System;

        public string ModuleName => "Cmds Module";

        public string Version => "0.0.0.1";

        public string Author => "";

        public void ModuleDeinitialize(Executer exec)
        {

        }

        public void ModuleInitialize(Executer exec)
        {
            
        }
    }
}
