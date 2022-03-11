using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Lt : BinaryOperator
    {
        public override void Operate(IProgrammable robot,params int[] operands)
        {
            robot.Stack.Push(operands[0] < operands[1] ? 1 : 0);
        }
        public override object Clone( )
        {
            return new Lt();
        }
        public override string ToString( )
        {
            return "lt";
        }
        public override bool Equals(object obj)
        {
            return obj is Lt;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
