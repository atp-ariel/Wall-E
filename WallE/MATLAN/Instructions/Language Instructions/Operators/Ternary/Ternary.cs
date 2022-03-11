using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Ternary : TernaryOperator
    {
        public override void Operate(IProgrammable robot,params int[] operands)
        {
            if ( operands[0] != 0 )
                robot.Stack.Push(operands[1]);
            else
                robot.Stack.Push(operands[2]);
        }
        public override object Clone( )
        {
            return new Ternary();
        }
        public override string ToString( )
        {
            return "ternary";
        }
        public override bool Equals(object obj)
        {
            return obj is Ternary;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
