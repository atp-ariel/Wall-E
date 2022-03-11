using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;


namespace WallE.MATLAN.Instructions
{
    public class Right : Instruction,IAction
    {
        public override object Clone( )
        {
            return new Right( );
        }
        public void Proceed(IProgrammable robot)
        {
            if ( robot.Directions == 3 )
            {
                robot.Directions = 0;
                return;
            }
            robot.Directions++;
        }

        public override void Execute(IProgrammable robot)
        {
            Proceed(robot);
        }
        public override string ToString( )
        {
            return "right";
        }
        public override bool Equals(object obj)
        {
            return obj is Right;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
