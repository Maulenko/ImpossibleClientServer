﻿using AwwareCmds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdTest
{
    class Program
    {
        public static Executer exec;
        static void Main(string[] args)
        {
            exec = new Executer(true, "Modules");
            exec.AttachModulesFromFolder();
            Out(exec.MODController.Modules.Count.ToString(), "");
            AEvents.OutputInfo += Info;
            AEvents.OutputError += Error;
            AEvents.OutputDebug += Debug;
            AEvents.OnCommandSleep += OnSleep;
            AEvents.OnCommandEnded += OnEnded;
            while (true) {
                exec.CommandHandler(Console.ReadLine());
            }
        }
        static void Out(string msg, params object[] args)
        {
            Console.WriteLine($"OUT: {msg}");
        }
        static void Info(string msg)
        {
            Console.WriteLine($"INFO: {msg}");
        }
        static void Error(string error)
        {
            Console.WriteLine($"ERROR: {error}");
        }
        static void Debug(string error)
        {
            Console.WriteLine($"DEBUG: {error}");
        }
        static void OnSleep(Task task)
        {
            Console.WriteLine("SLEEEPP!!!!");
        }
        static void OnEnded()
        {
            Console.WriteLine("Cmd ended.");
        }
    }
}
