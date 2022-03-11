using System;
using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class NW : Instruction, IControlFlux
    {
        public override void Execute(IProgrammable robot)
        {
            Control(robot.ExecutingStack.Peek( ));
        }
        public override object Clone( )
        {
            return new NW( );
        }
        public override string ToString( )
        {
            return "NW";
        }
        public void Control(Rut routine)
        {
            var flux = routine.Body.Flux;
            if ( flux.Direction == 2 )
                flux.Direction = 3;
            else if ( flux.Direction == 1 )
                flux.Direction = 0;
            else
                return;
        }
        public override bool Equals(object obj)
        {
            return obj is NW;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
