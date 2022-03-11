using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Not : AtomicOperator
    {
        public override void Operate(IProgrammable robot,int[] operand)
        {
            robot.Stack.Push(operand[0] != 0 ? 0 : 1);
        }
        public override object Clone( )
        {
            return new Not();
        }
        public override string ToString( )
        {
            return "not";
        }
        public override bool Equals(object obj)
        {
            return obj is Not;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
