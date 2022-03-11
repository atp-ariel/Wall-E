using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class RecCall : Instruction
    {
        public override void Execute(IProgrammable robot)
        {
            Routine thisRoutine = new Routine( );
            thisRoutine.Execute(robot);

            Call thisCallRoutine = new Call( );
            thisCallRoutine.Execute(robot);
        }
        public override string ToString( )
        {
            return "recCall";
        }
        public override object Clone( )
        {
            return new RecCall( );
        }
        public override bool Equals(object obj)
        {
            return obj is RecCall;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
