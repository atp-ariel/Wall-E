using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class Return : Instruction, IControlFlux
    {
        public override void Execute(IProgrammable robot)
        {
            Control(robot.ExecutingStack.Peek( ));
        }
        public override string ToString( )
        {
            return "return";
        }
        public override object Clone( )
        {
            return new Return();
        }

        public void Control(Rut routine)
        {
            routine.Executing = false;
            routine.Body.FluxReset( );
        }
        public override bool Equals(object obj)
        {
            return obj is Return;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
