using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class Balance : Instruction,ISensor
    {
        public void Active(ISensitive robot)
        {

            robot.Loaded( );
        }

        public override object Clone( )
        {
            return new Balance( );
        }

        public override void Execute(IProgrammable robot)
        {
            if ( robot is ISensitive )
                Active(robot as ISensitive);
            else
                Simulator.Simulator.ReportError(robot,new Errors.Error("Este objeto programable no implementa este sensor."));
        }
        public override string ToString( )
        {
            return "loaded";
        }
        public override bool Equals(object obj)
        {
            return obj is Balance;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
