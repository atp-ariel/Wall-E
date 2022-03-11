using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Errors;
using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public class Routine : Instruction
    {

        public override void Execute(IProgrammable robot)
        {
            var index = robot.ExecutingStack.Peek( ).Index;
            try {
                robot.Stack.Push(index); }
            catch ( Exception )
            {
                Error error = new Error("La pila del robot está llena, por tanto no puede añadir el índice de la rutina.");
                Simulator.Simulator.ReportError(robot,error);
                return;
            }
        }
        public override string ToString( )
        {
            return "routine";
        }
        public override object Clone( )
        {
            return new Routine();
        }
        public override bool Equals(object obj)
        {
            return obj is Routine;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }

}
