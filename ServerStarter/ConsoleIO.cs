using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace ServerStarter
{
    public static class ConsoleIO
    {
        public static void ColorWriteLine(string msg, System.Drawing.Color color) => Console.WriteLine(msg, color);
        public static void Info(string msg) => ColorWriteLine($"[INFO] {msg}", System.Drawing.ColorTranslator.FromHtml("#6FBDF4"));
        public static void Error(string msg) => ColorWriteLine($"[ERROR] {msg}", System.Drawing.ColorTranslator.FromHtml("#6B0D0D"));
        public static void Warn(string msg) => ColorWriteLine($"[WARN] {msg}", System.Drawing.ColorTranslator.FromHtml("#D4BB00"));
        public static void Debug(string msg) => ColorWriteLine($"[DEBUG] {msg}", System.Drawing.ColorTranslator.FromHtml("#DEDEDE"));
    }
}
