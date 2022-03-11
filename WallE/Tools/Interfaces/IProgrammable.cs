using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Routine;
using WallE.Simulator;

namespace WallE.Tools
{
    /// <summary>
    /// Representa el comportamiento de todo objeto que se programe.
    /// </summary>
    public interface IProgrammable
    {
        LinealMemory Memory { get; set; }
        Stack<int> Stack { get; set; }
        Stack<Rut> ExecutingStack { get; set; }
        RoutineList ListRoutine { get; set; }
        int Times { get; set; }
        void Back( );
        void Advance( );
        int Directions { get; set; }
    }
}
