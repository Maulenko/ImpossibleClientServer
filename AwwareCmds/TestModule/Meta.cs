﻿using AwwareCmds;
using AwwareCmds.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModule
{
    public class Meta : IModuleInfo
    {
        public ModuleKind Kind => ModuleKind.Default;

        public string ModuleName => "Test Module";

        public string Version => "1.0.0.0";

        public string Author => "Awware";

        public void ModuleDeinitialize(Executer exec)
        {

        }

        public void ModuleInitialize(Executer exec)
        {
            AEvents.OutputAction("Test Module Inited!", AEvents.OutTypes.Info);
        }
    }
}
