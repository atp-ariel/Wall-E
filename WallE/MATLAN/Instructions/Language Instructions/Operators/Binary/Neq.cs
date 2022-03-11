using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Neq : BinaryOperator
    {
        public override void Operate(IProgrammable robot,params int[] operands)
        {
            robot.Stack.Push(operands[0] != operands[1] ? 1 : 0);
        }
        public override object Clone( )
        {
            return new Neq();
        }
        public override string ToString( )
        {
            return "neq";
        }
        public override bool Equals(object obj)
        {
            return obj is Neq;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
