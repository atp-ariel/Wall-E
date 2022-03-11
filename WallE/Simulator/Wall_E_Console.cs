using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using System.Media;

namespace WallE.Simulator
{
    public static class WallE_Console
    {
        static string message;
        public static string Message =>  message;
        public static event EventHandler OnPrint;
        public static void Print(IProgrammable sender, string msg)
        {
            message = msg;
            OnPrint(sender, new EventArgs());  
        }
        public static void PrintError(IProgrammable sender,Errors.Error error)
        {
            message = error.Message;
            SystemSounds.Exclamation.Play( );
            OnPrint(sender,new EventArgs( ));
        }

    }
}
