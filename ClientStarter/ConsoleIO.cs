using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace ClientStarter
{
    public static class ConsoleIO
    {
        public static void ColorWriteLine(string msg, System.Drawing.Color color) => Console.WriteLine(msg, color);
        public static void Info(string msg) => ColorWriteLine($"[INFO] {msg}", System.Drawing.ColorTranslator.FromHtml("#4F9FE9"));
        public static void Success(string msg) => ColorWriteLine($"[SUCCESS] {msg}", System.Drawing.ColorTranslator.FromHtml("#64F175"));
        public static void Error(string msg) => ColorWriteLine($"[ERROR] {msg}", System.Drawing.ColorTranslator.FromHtml("#D55151"));
        public static void Warn(string msg) => ColorWriteLine($"[WARN] {msg}", System.Drawing.ColorTranslator.FromHtml("#F0EE4D"));
        public static void Debug(string msg) => ColorWriteLine($"[DEBUG] {msg}", System.Drawing.ColorTranslator.FromHtml("#DEDEDE"));
        public static void Custom(string begin, string msg, string color) => ColorWriteLine($"[{begin}] {msg}", System.Drawing.ColorTranslator.FromHtml(color));
    }
}
