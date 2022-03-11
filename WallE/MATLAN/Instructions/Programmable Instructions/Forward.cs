using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;


namespace WallE.MATLAN.Instructions
{
    public class Forward : Instruction,IAction
    {
        public override object Clone( )
        {
            return new Forward( );
        }

        public override void Execute(IProgrammable robot)
        {
            Proceed(robot);
        }

        public void Proceed(IProgrammable robot)
        {
            robot.Advance( );
        }

        public override string ToString( )
        {
            return "forward";
        }
        public override bool Equals(object obj)
        {
            return obj is Forward;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }

}
