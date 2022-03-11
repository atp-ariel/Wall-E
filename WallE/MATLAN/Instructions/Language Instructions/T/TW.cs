using System;
using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class TW : Instruction, IControlFlux
    {
        public override void Execute(IProgrammable robot)
        {
            Control(robot.ExecutingStack.Peek( ));
        }
        public override object Clone( )
        {
            return new TW( );
        }
        public override string ToString( )
        {
            return "TW";
        }

        public void Control(Rut routine)
        {
            var flux = routine.Body.Flux;

            if ( flux.Direction == 2 || flux.Direction == 0 )
                flux.Direction = 3;
            else if ( flux.Direction == 1 )
            {
                Random rndm = new Random( );
                byte[] possibleCases = new byte[] { 2,0 };
                flux.Direction = possibleCases[rndm.Next(2)];
            }
        }
        public override bool Equals(object obj)
        {
            return obj is TW;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
