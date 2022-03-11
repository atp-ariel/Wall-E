using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.Errors;

namespace WallE.MATLAN.Instructions
{
    public class Print : Instruction
    {
        public override void Execute(IProgrammable robot)
        {
            int valueToPrint = 0;

            try { valueToPrint = robot.Stack.Pop( ); }
            catch ( Exception )
            {
                Error error = new Error("Pila vacía, por tanto no existe nada que imprimir.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.PrintError(robot,error);
                return;
            }
             WallE.Simulator.WallE_Console.Print(robot,valueToPrint.ToString());
        }
        public override object Clone( )
        {
            return new Print();
        }
        public override string ToString( )
        {
            return "print";
        }
        public override bool Equals(object obj)
        {
            return obj is Print;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
