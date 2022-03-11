using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Eq : BinaryOperator
    {
        public override void Operate(IProgrammable robot,params int[] operands)
        {
            robot.Stack.Push(operands[0] == operands[1] ? 1 : 0);
        }
        public override object Clone( )
        {
            return new Eq();
        }
        public override string ToString( )
        {
            return "eq";
        }
        public override bool Equals(object obj)
        {
            return obj is Eq;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
