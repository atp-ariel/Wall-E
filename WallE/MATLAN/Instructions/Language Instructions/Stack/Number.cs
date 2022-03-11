using System;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class Number : Instruction
    {
        public override void Execute(IProgrammable robot)
        {
            try
            {
                robot.Stack.Push(0);
            }
            catch ( Exception )
            {
                Errors.Error error = new Errors.Error("La pila del robot está llena, por tanto no podrá añadir el cero.");
                Simulator.Simulator.ReportError(robot,error);
            }
        }
        public override object Clone( )
        {
            return new Number();
        }
        public override string ToString( )
        {
            return "number";
        }
        public override bool Equals(object obj)
        {
            return obj is Number;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
