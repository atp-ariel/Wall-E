using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Dec : AtomicOperator
    {
        public override void Operate(IProgrammable robot,int[] operand)
        {
            robot.Stack.Push(operand[0] - 1);
        }
        public override object Clone( )
        {
            return new Dec();
        }
        public override string ToString( )
        {
            return "dec";
        }
        public override bool Equals(object obj)
        {
            return obj is Dec;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
