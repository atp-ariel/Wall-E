using System;
using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class SE : Instruction, IControlFlux
    {
        public override void Execute(IProgrammable robot)
        {
            Control(robot.ExecutingStack.Peek( ));
        }
        public override object Clone( )
        {
            return new SE( );
        }
        public override string ToString( )
        {
            return "SE";
        }
        public void Control(Rut routine)
        {
            var flux = routine.Body.Flux;
            if ( flux.Direction == 0 )
                flux.Direction = 1;
            else if ( flux.Direction == 3 )
                flux.Direction = 2;
            else
                return;
        }
        public override bool Equals(object obj)
        {
            return obj is SE;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
