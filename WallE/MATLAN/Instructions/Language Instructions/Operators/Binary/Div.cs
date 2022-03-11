using System;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Div : BinaryOperator
    {
        public override void Operate(IProgrammable robot,params int[] operands)
        {
            if ( operands[1] == 0 )
                throw new DivideByZeroException("No puede dividir por cero.");
            robot.Stack.Push(operands[0] / operands[1]);
        }
        public override object Clone( )
        {
            return new Div();
        }
        public override string ToString( )
        {
            return "div";
        }
        public override bool Equals(object obj)
        {
            return obj is Div;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
