using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.Errors;

namespace WallE.MATLAN.Instructions
{
    public abstract class TernaryOperator : Instruction, IOperator<int>
    {
        public override void Execute(IProgrammable robot)
        {
            int condition, operand1, operand2;
            if(robot.Stack.Count < 3)
            {
                Error error = new Error("La pila no tiene los suficientes elementos para operar ternariamente.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.PrintError(robot,error);
                return;
            }
            operand2 = robot.Stack.Pop( );
            operand1 = robot.Stack.Pop( );
            condition = robot.Stack.Pop( );
            Operate(robot,condition,operand1,operand2);
        }
        public abstract void Operate(IProgrammable robot,params int[] operands);
    }
}
