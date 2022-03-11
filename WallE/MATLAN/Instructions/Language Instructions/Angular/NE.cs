using System;
using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class NE : Instruction, IControlFlux
    {
        public override void Execute(IProgrammable robot)
        {
            Control(robot.ExecutingStack.Peek( ));
        }
        public override string ToString( )
        {
            return "NE";
        }
        public override object Clone( )
        {
            return new NE( );
        }
        public void Control(Rut routine)
        {
            var flux = routine.Body.Flux;
            if ( flux.Direction == 2 )
                flux.Direction = 1;
            else if ( flux.Direction == 3 )
                flux.Direction = 0;
            else
                return;
        }
        public override bool Equals(object obj)
        {
            return obj is NE;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
