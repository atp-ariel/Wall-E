using System;
using WallE.Errors;
using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class Call : Instruction
    {
        public override void Execute(IProgrammable robot)
        {
            int indexRoutine = 0;
            try { indexRoutine = robot.Stack.Pop( ); }
            catch ( Exception )
            {
                Error error = new Error("Pila vacía, por tanto no puede sacar un índice para una rutina.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.Print(robot,error.Message);
                return;
            }
            if ( robot.ListRoutine.Count - 1 < indexRoutine )
            {
                Error error = new Error("Ese índice no es válido en la lista de las rutinas.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.Print(robot,error.Message);
                return;
            }
            Rut routineCall = (Rut) robot.ListRoutine[indexRoutine].Clone( );
            routineCall.RobotRoutine = robot;

            try
            {
                robot.ExecutingStack.Push(routineCall);
            }
            catch ( Exception )
            {
                Errors.Error.ReportError(robot,new Error("La pila de ejecución está llena."));
            }

            routineCall.Executing = true;
            if ( Simulator.Round.IsExecutingByInstruction )
                routineCall.ExecuteByInstruction( );
            else
                routineCall.Execute( );
            if ( !robot.ExecutingStack.Peek( ).Executing )
                robot.ExecutingStack.Pop( );
        }
        public override object Clone( )
        {
            return new Call( );
        }
        public override string ToString( )
        {
            return "call";
        }
        public override bool Equals(object obj)
        {
            return obj is Call;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
