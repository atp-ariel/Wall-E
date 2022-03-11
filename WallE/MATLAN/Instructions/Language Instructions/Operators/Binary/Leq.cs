using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Leq : BinaryOperator
    {
        public override void Operate(IProgrammable robot,params int[] operands)
        {
            robot.Stack.Push(operands[0] <= operands[1] ? 1 : 0);
        }
        public override object Clone( )
        {
            return new Leq();
        }
        public override string ToString( )
        {
            return "leq";
        }
        public override bool Equals(object obj)
        {
            return obj is Leq;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
