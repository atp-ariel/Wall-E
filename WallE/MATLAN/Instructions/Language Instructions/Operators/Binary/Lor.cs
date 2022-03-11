using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Lor : BinaryOperator
    {
        public override void Operate(IProgrammable robot,params int[] operands)
        {
            robot.Stack.Push(operands[0] | operands[1]);
        }
        public override object Clone( )
        {
            return new Lor();
        }
        public override string ToString( )
        {
            return "lor";
        }
        public override bool Equals(object obj)
        {
            return obj is Lor;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
