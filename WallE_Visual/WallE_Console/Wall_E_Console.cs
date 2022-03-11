using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallE.Simulator;
using WallE.Tools;
using WallE.World.WorldObjects;

namespace WallE_Visual
{
    public partial class Wall_E_Console : UserControl
    {
        LinkedList<string> messages = new LinkedList<string>( );

        public Wall_E_Console( )
        {
            InitializeComponent( );
            WallE_Console.OnPrint += PrintInConsole; 
        }

        private void PrintInConsole(object sender, EventArgs e)
        {
            string msg = WallE_Console.Message;
            messages.AddLast(">>> " + (Shapes)((WallEObjects) sender ).ObjShape + " " + ((WallEObjects) sender ).ObjNumber.ToString() + ": " +  msg);

            this.rtboxConsole.Text = MessagesInString( ) + "_";
            
        }

        public void Clear( )
        {
            this.rtboxConsole.Clear( );
            this.messages.Clear( );
        }
        private string MessagesInString( )
        {
            string tempMsg = string.Empty;

            foreach ( var msg in messages )
                tempMsg += msg + "\n";
            return tempMsg;
        }
    }
}
