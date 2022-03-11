using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.World;
using WallE.World.WorldObjects;
using WallE.MATLAN;
using WallE.Routine;


namespace WallE.Simulator
{
    public class Round : IEnumerable<IProgrammable>
    {
        public static bool IsExecutingByInstruction { get; private set; }
        /// <summary>
        ///Lista con todos los objetos IProgrammables de la simulación. 
        /// </summary>
        List<IProgrammable> tempListProgrammable;
        /// <summary>
        /// Enumerator de la ronda.
        /// </summary>
        IEnumerator<IProgrammable> enumerator;

        bool lastExecutionInstruction;

        /// <summary>
        /// Constructor de la ronda
        /// </summary>
        /// <param name="tempListProgrammable">Lista de todos los objetos IProgrammables del mundo.</param>
        public Round(List<IProgrammable> tempListProgrammable)
        {
            //Guardo la lista en el campo tempListProgrammable
            this.tempListProgrammable = tempListProgrammable;
            //Tomo el enumerator de la ronda.
            enumerator = GetEnumerator( );
            enumerator.MoveNext( );
        }

        /// <summary>
        /// Devuelve un enumerator de objetos IProgrammables.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<IProgrammable> GetEnumerator( )
        {
            return new RoundEnumerator(tempListProgrammable);
        }
        /// <summary>
        /// Devuelve un enumerator de object.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );

        /// <summary>
        /// Ejecuta las listas de roboces hasta llegar a una acción física.
        /// </summary>
        internal void Execute( )
        {
            IsExecutingByInstruction = false;
            foreach ( var item in this )
            {
                item.Times++;
                item.ListRoutine.Execute( );
                if(Simulator.CurrentError != null)
                    return;
            }
        }
        /// <summary>
        /// Ejecuta las listas de rutinas hasta llegar a una acción física pero instrucción por instrucción.
        /// </summary>
        /// <returns></returns>
        internal bool ExecuteByInstruction( )
        {
            IsExecutingByInstruction = true;
            bool isntLastProgrammable = true;
            if ( !lastExecutionInstruction )
                lastExecutionInstruction = enumerator.Current.ListRoutine.ExecuteByInstruction( );
            else
            {
                enumerator.Current.Times++;
                if ( isntLastProgrammable = enumerator.MoveNext( ) )
                {
                    lastExecutionInstruction = enumerator.Current.ListRoutine.ExecuteByInstruction( );
                    enumerator.Current.Times++;
                }
            }
            return isntLastProgrammable;
        }


        class RoundEnumerator : IEnumerator<IProgrammable>
        {
            /// <summary>
            /// Índice para la lista de objetos IProgrammables.
            /// </summary>
            int index;
            /// <summary>
            /// Lista de objetos IProgrammable.
            /// </summary>
            List<IProgrammable> tempListProgrammable;
            /// <summary>
            /// Objeto IProgrammble actual.
            /// </summary>
            IProgrammable current;
            /// <summary>
            /// Booleano que determina si hubo un movimiento.
            /// </summary>
            bool move;

            public RoundEnumerator(List<IProgrammable> tempListProgrammable)
            {
                this.tempListProgrammable = tempListProgrammable;
                this.index = -1;
            }
            public IProgrammable Current
            {
                get
                {
                    if ( !move )
                        throw new InvalidOperationException("No ha hecho .MoveNext()");
                    return current;
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose( )
            {
                return;
            }

            public bool MoveNext( )
            {
                if ( ++index < tempListProgrammable.Count )
                {
                    current = tempListProgrammable[index];
                    return move = true;
                }
                else return move = false;
            }

            public void Reset( )
            {
                this.current = null;
                this.move = false;
                this.index = -1;
            }
        }

    }
}
