using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.Errors;

namespace WallE.MATLAN.Instructions
{
    public abstract class AtomicOperator : Instruction, IOperator<int>
    {
        public override void Execute(IProgrammable robot)
        {
            int value = 0;
            try { value = robot.Stack.Pop( ); }
            catch ( Exception )
            {
                Error error = new Error("La pila no tiene la cantidad suficiente de elementos para operar unariamente.");
                if(Simulator.Simulator.NoAllowErrors)
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.PrintError(robot,error);
                return;
            }
            Operate(robot,value);
        }

        public abstract void Operate(IProgrammable robot,params int[] operand);

    }
}
