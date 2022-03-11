using System;
using WallE.Errors;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class One : Instruction
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
                Error error = new Error("Pila vacía, por tanto no puede sacar un valor para {one}.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.PrintError(robot,error);
                return;
            }
            try
            {
                robot.Stack.Push(( 2 * lastValueStack ) + 1);
            }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Error("La pila del robot está llena, no podrá añadir ese valor."));
            }
        }
        public override object Clone( )
        {
            return new One( );
        }
        public override string ToString( )
        {
            return "one";
        }
        public override bool Equals(object obj)
        {
            return obj is One;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
