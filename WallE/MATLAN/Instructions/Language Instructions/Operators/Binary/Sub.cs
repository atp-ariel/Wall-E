using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Sub : BinaryOperator
    {
        public override void Operate(IProgrammable robot,params int[] operands)
        {
            robot.Stack.Push(operands[0] - operands[1]);
        }
        public override object Clone( )
        {
            return new Sub();
        }
        public override string ToString( )
        {
            return "sub";
        }
        public override bool Equals(object obj)
        {
            return obj is Sub;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
