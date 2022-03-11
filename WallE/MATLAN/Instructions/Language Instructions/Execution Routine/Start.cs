using WallE.Tools;
using WallE.Routine;
using System;

namespace WallE.MATLAN.Instructions
{

    //Ver bien....
    public class Start : Instruction, IControlFlux
    {
        public override void Execute(IProgrammable robot)
        {
            Control(robot.ExecutingStack.Peek( ));
        }
        public override string ToString( )
        {
            return "start";
        }
        public override object Clone( )
        {
            return new Start();
        }
        public void Control(Rut routine)
        {
            routine.Executing = true;
            routine.Body.Flux.Direction = 2;
        }
        public override bool Equals(object obj)
        {
            return obj is Start;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }

}
