using System;
using WallE.Tools;
using WallE.Errors;

namespace WallE.MATLAN.Instructions
{
    public class GetAt : Instruction
    {
        public override void Execute(IProgrammable robot)
        {
            int index = 0;

            try { index = robot.Stack.Pop( ); }
            catch ( Exception )
            {
                Error error = new Error("Pila vacía, por tanto no puede sacar un índice de la pila para el {getAt}.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.PrintError(robot,error);
                return;
            }

            int value = 0;

            try { value = robot.Memory[index]; }
            catch ( Exception e)
            {
                WallE.Simulator.WallE_Console.Print(robot,new Error(e.Message).ToString( ));
                return;
            }

            robot.Stack.Push(value);
        }
        public override object Clone( )
        {
            return new GetAt( );
        }
        public override string ToString( )
        {
            return "getAt";
        }
        public override bool Equals(object obj)
        {
            return obj is GetAt;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
