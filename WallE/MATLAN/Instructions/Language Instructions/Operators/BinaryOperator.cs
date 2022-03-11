using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Errors;
using WallE.Tools;


namespace WallE.MATLAN.Instructions
{
    public abstract class BinaryOperator : Instruction, IOperator<int>
    {
        public override void Execute(IProgrammable robot)
        {
            int operand1, operand2;
            if(robot.Stack.Count < 2)
            {
                Error error = new Error("La pila no tiene la cantidad suficiente de elementos para operar binariamente.");
                if(Simulator.Simulator.NoAllowErrors)
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.PrintError(robot,error);
                return;
            }
            operand2 = robot.Stack.Pop( );
            operand1 = robot.Stack.Pop( );
            Operate(robot,operand1,operand2);
        }

        public abstract void Operate(IProgrammable robot,params int[] operands);
    }
}
