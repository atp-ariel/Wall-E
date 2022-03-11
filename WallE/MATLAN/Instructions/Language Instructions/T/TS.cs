using System;
using WallE.Routine;
using WallE.Tools;


namespace WallE.MATLAN.Instructions
{
    public class TS : Instruction, IControlFlux
    {
        public override void Execute(IProgrammable robot)
        {
            Control(robot.ExecutingStack.Peek( ));
        }

        public override object Clone( )
        {
            return new TS( );
        }
        public override string ToString( )
        {
            return "TS";
        }

        public void Control(Rut routine)
        {
            var flux = routine.Body.Flux;

            if ( flux.Direction == 3 || flux.Direction == 1 )
                flux.Direction = 2;
            else if ( flux.Direction == 0)
            {
                Random rndm = new Random( );
                byte[] possibleCases = new byte[] { 1,3 };
                flux.Direction = possibleCases[rndm.Next(2)];
            }
        }
        public override bool Equals(object obj)
        {
            return obj is TS;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
