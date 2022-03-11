using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;


namespace WallE.MATLAN.Instructions
{
    public class Backward : Instruction,IAction
    {
        public override void Execute(IProgrammable robot) => Proceed(robot);
        public override object Clone( ) => new Backward( );
        public override string ToString( ) => "backward";
        public override bool Equals(object obj)
        {
            return obj is Backward;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
        public void Proceed(IProgrammable robot) => robot.Back( );
    }
}
