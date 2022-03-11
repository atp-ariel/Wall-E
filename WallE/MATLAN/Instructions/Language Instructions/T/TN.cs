using System;
using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class TN : Instruction, IControlFlux
    {
        public override void Execute(IProgrammable robot)
        {
            Control(robot.ExecutingStack.Peek( ));
        }
        public override object Clone( )
        {
            return new TN( );
        }
        public override string ToString( )
        {
            return "TN";
        }
        public void Control(Rut routine)
        {
            var flux = routine.Body.Flux;

            if ( flux.Direction == 3 || flux.Direction == 1 )
                flux.Direction = 0;
            else if ( flux.Direction == 2 )
            {
                Random rndm = new Random( );
                byte[] possibleCases = new byte[] { 1,3 };
                flux.Direction = possibleCases[rndm.Next(2)];
            }
        }
        public override bool Equals(object obj)
        {
            return obj is TN;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
