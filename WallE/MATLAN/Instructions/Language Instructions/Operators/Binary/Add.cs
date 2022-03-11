using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Add : BinaryOperator
    {
        public override void Operate(IProgrammable robot,params int[] operands)
        {
            robot.Stack.Push(operands[0] + operands[1]);
        }
        public override object Clone( )
        {
            return new Add();
        }
        public override string ToString( )
        {
            return "add";
        }
        public override bool Equals(object obj)
        {
            return obj is Add;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
