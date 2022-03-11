using System;
using WallE.Routine;
using WallE.Tools;
using WallE.Errors;

namespace WallE.MATLAN.Instructions
{
    public class Branch : Instruction, IControlFlux
    {
        private int condition;
        public override void Execute(IProgrammable robot)
        {
            try {
                condition = robot.Stack.Pop( ); }
            catch ( Exception )
            {
                Error error = new Error("Pila vacía, por tanto no puede sacar condición para el {branch}.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                Simulator.WallE_Console.PrintError(robot,error);
                return;
            }
            Control(robot.ExecutingStack.Peek( ));       
        }
        public override string ToString( )
        {
            return "branch";
        }
        public override object Clone( )
        {
            return new Branch();
        }

        public void Control(Rut routine)
        {
            if ( condition == 0 )
            {
                if ( routine.Body.Flux.Direction == 0 )
                    routine.Body.Flux.Direction = 3;
                else
                    routine.Body.Flux.Direction--;
            }
            else
            {
                if ( routine.Body.Flux.Direction == 3 )
                    routine.Body.Flux.Direction = 0;
                else
                    routine.Body.Flux.Direction++;
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Branch;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
