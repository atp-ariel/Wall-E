using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class Land : BinaryOperator
    {
        public override void Operate(IProgrammable robot,params int[]operands)
        {
            robot.Stack.Push(operands[0] & operands[1]);
        }
        public override object Clone( )
        {
            return new Land();
        }
        public override string ToString( )
        {
            return "land";
        }
        public override bool Equals(object obj)
        {
            return obj is Land;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
