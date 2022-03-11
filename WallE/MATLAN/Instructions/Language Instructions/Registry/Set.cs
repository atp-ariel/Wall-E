using System;
using WallE.Errors;
using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public abstract class Set : Instruction
    {
        public override void Execute(IProgrammable robot)
        {
            int value = 0;

            try { value = robot.Stack.Pop( ); }
            catch(Exception)
            {
                Error error = new Error("Pila vacía, por tanto no puede sacar un valor para poner en el registro de la rutina.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.Print(robot,error.Message);
                return;
            }

            SetByChar(robot.ExecutingStack.Peek(),value);
        }

        protected abstract void SetByChar(Rut routine,int value);

    }

}
