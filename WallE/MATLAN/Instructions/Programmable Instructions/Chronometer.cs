using System;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class Chronometer : Instruction, ISensor
    {
        public void Active(ISensitive robot)
        {
            robot.Time( );
        }

        public override object Clone( )
        {
            return new Chronometer( );
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
            return "time";
        }
        public override bool Equals(object obj)
        {
            return obj is Chronometer;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
