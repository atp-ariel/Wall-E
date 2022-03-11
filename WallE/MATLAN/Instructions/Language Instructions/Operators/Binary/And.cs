using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class And : BinaryOperator
    {
        public override void Operate(IProgrammable robot,params int[] operands)
        {
            if ( operands[0] == 0 || operands[1] == 0 )
                robot.Stack.Push(0);
            else
                robot.Stack.Push(1);
        }
        public override object Clone( )
        {
            return new And();
        }
        public override string ToString( )
        {
            return "and";
        }
        public override bool Equals(object obj)
        {
            return obj is And;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
