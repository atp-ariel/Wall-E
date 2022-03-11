using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Gt : BinaryOperator
    {
        public override void Operate(IProgrammable robot, params int[] operands)
        {
            robot.Stack.Push(operands[0] > operands[1] ? 1 : 0);
        }
        public override object Clone( )
        {
            return new Gt();
        }
        public override string ToString( )
        {
            return "gt";
        }
        public override bool Equals(object obj)
        {
            return obj is Gt;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
