using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Inc : AtomicOperator
    {
        public override void Operate(IProgrammable robot,int[] operand)
        {
            robot.Stack.Push(operand[0] + 1);
        }
        public override object Clone( )
        {
            return new Inc();
        }
        public override string ToString( )
        {
            return "inc";
        }
        public override bool Equals(object obj)
        {
            return obj is Inc;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
