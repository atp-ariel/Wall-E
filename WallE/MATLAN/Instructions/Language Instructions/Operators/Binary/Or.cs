using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Or : BinaryOperator
    {
        public override void Operate(IProgrammable robot, params int[] operands)
        {
            if ( operands[0] != 0 || operands[1] != 0 )
                robot.Stack.Push(1);
            else
                robot.Stack.Push(0);
        }
        public override object Clone( )
        {
            return new Or();
        }
        public override string ToString( )
        {
            return "or";
        }
        public override bool Equals(object obj)
        {
            return obj is Or;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
