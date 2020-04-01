using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ClientEvents
{
    /// <summary>
    /// Begin, msg, color
    /// </summary>
    public static Action<string, string, string> Custom;
    /// <summary>
    /// MSG
    /// </summary>
    public static Action<string> Info;
    /// <summary>
    /// MSG
    /// </summary>
    public static Action<string> Success;
    /// <summary>
    /// MSG
    /// </summary>
    public static Action<string> Error;
    /// <summary>
    /// MSG
    /// </summary>
    public static Action<string> Warn;
    /// <summary>
    /// MSG
    /// </summary>
    public static Action<string> Debug;
}
