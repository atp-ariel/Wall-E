using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class Compass : Instruction, ISensor
    {
        public override void Execute(IProgrammable robot)
        {
            if ( robot is ISensitive )
                Active(robot as ISensitive);
            else
                Simulator.Simulator.ReportError(robot,new Errors.Error("Este objeto programable no implementa este sensor."));
        }
        public override object Clone( )
        {
            return new Compass( );
        }
        public override string ToString( )
        {
            return "direction";
        }

        public void Active(ISensitive robot)
        {
            robot.Direction( );
        }
        public override bool Equals(object obj)
        {
            return obj is Compass;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
