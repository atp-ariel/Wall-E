using System;
using WallE.Tools;
namespace WallE.MATLAN.Instructions
{
    public class BarcodeScanner : Instruction, ISensor
    {
        public override void Execute(IProgrammable robot)
        {
            if ( robot is ISensitive )
                Active( robot as ISensitive);
            else
                Simulator.Simulator.ReportError(robot,new Errors.Error("Este objeto programable no implementa este sensor."));
        }
        public override object Clone( )
        {
            return new BarcodeScanner( );
        }
        public override string ToString( )
        {
            return "code";
        }

        public void Active(ISensitive robot)
        {
            robot.Code( );
        }
        public override bool Equals(object obj)
        {
            return obj is BarcodeScanner;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }   
}
