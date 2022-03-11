using System;
using WallE.Tools;
using WallE.Errors;

namespace WallE.MATLAN.Instructions
{
    public class SetAt : Instruction
    {
        public override void Execute(IProgrammable robot)
        {
            int index = 0;
            try { index = robot.Stack.Pop( ); }
            catch ( Exception )
            {
                Error error = new Error("Pila vacía, por tanto no puede sacar un índice de la pila para el {setAt}.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.PrintError(robot,error);
                return;
            }
            int value = 0;

            try { value = robot.Stack.Pop(); }
            catch ( Exception )
            {
                Error error = new Error("Pila vacía, por tanto no puede insertar un valor en la memoria lineal.");
                if(Simulator.Simulator.NoAllowErrors)
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.Print(robot,error.Message);
                return;
            }

            robot.Memory[index] = value;
        }
        public override object Clone( )
        {
            return new SetAt();
        }
        public override string ToString( )
        {
            return "setAt";
        }
        public override bool Equals(object obj)
        {
            return obj is SetAt;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
