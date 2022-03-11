using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Geq : BinaryOperator
    {
        public override void Operate(IProgrammable robot, params int[] operands)
        {
            robot.Stack.Push(operands[0] >= operands[1] ? 1 : 0);
        }
        public override object Clone( )
        {
            return new Geq();
        }
        public override string ToString( )
        {
            return "geq";
        }
        public override bool Equals(object obj)
        {
            return obj is Geq;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
