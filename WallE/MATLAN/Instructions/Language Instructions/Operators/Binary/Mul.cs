using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Mul : BinaryOperator
    {
        public override void Operate(IProgrammable robot,params int[] operands)
        {
            robot.Stack.Push(operands[0] * operands[1]);
        }
        public override object Clone( )
        {
            return new Mul();
        }
        public override string ToString( )
        {
            return "mul";
        }
        public override bool Equals(object obj)
        {
            return obj is Mul;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
