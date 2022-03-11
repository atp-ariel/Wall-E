using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.MATLAN.Instructions;

namespace WallE.MATLAN.InstructionFactory
{
    public class SubFactory : InstructionsFactory
    {
        public override Instruction Create( ) => new Sub( );
    }
}
