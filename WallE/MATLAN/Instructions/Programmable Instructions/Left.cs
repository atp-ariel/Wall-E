using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;


namespace WallE.MATLAN.Instructions
{
    public class Left : Instruction,IAction
    {
        public override object Clone( )
        {
            return new Left( );
        }

        public override void Execute(IProgrammable robot)
        {
            Proceed(robot);
        }

        public void Proceed(IProgrammable robot)
        {
            if ( robot.Directions == 0 )
            {
                robot.Directions = 3;
                return;
            }
            robot.Directions--;
        }

        public override string ToString( )
        {
            return "left";
        }
        public override bool Equals(object obj)
        {
            return obj is Left;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
