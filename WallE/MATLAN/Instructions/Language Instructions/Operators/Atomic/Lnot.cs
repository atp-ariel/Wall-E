using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Lnot : AtomicOperator
    {
        public override void Operate(IProgrammable robot,int[] operand)
        {
            robot.Stack.Push(~operand[0]);
        }
        public override object Clone( )
        {
            return new Lnot();
        }
        public override string ToString( )
        {
            return "lnot";
        }
        public override bool Equals(object obj)
        {
            return obj is Lnot;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
