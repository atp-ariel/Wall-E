using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public abstract class Get : Instruction
    {
        public override void Execute(IProgrammable robot)
        {
            GetByChar(robot,robot.ExecutingStack.Peek());
        }
        protected abstract void GetByChar(IProgrammable robot,Rut routine);
    }
}
