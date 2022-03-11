using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Lxor : BinaryOperator
    {
        public override void Operate(IProgrammable robot, params int[] operands)
        {
            robot.Stack.Push(operands[0] ^ operands[1]);
        }
        public override object Clone( )
        {
            return new Lxor();
        }
        public override string ToString( )
        {
            return "lxor";
        }
        public override bool Equals(object obj)
        {
            return obj is Lxor;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
