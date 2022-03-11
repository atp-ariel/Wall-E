using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.Routine;

namespace WallE.MATLAN.Instructions
{
    public class HorizontalFlux : Instruction, IControlFlux
    {
        public override object Clone( ) => new HorizontalFlux( );

        public void Control(Rut routine) { }

        public override void Execute(IProgrammable robot)
        {
            Control((Rut) robot.ExecutingStack.Peek( ));
        }
        public override string ToString( ) => "horizontalFlux";
        public override bool Equals(object obj)
        {
            return obj is HorizontalFlux;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
