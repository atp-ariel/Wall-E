using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WallE.MATLAN.Instructions;
using System.Threading.Tasks;

namespace WallE.MATLAN.InstructionFactory
{
    public class TimeFactory : InstructionsFactory
    {
        public override Instruction Create( ) => new Chronometer( );
    }
}
