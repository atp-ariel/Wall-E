using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Errors;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class Zero : Instruction
    {
        public override void Execute(IProgrammable robot)
        {
            int lastValueStack = 0;
            try
            {
                lastValueStack = robot.Stack.Pop( );
            }
            catch ( Exception )
            {
                Error error = new Error("Pila vacía, por tanto no puede sacar un valor para {zero}.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.Print(robot,error.Message);
                Simulator.Simulator.CurrentError = error;
            }
            try
            {
                robot.Stack.Push( 2 * lastValueStack);
            }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override object Clone( )
        {
            return new Zero();
        }
        public override string ToString( )
        {
            return "zero";
        }
        public override bool Equals(object obj)
        {
            return obj is Zero;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
