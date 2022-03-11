using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using WallE.Tools;
using WallE.World.WorldObjects;
using WallE.MATLAN;

namespace WallE.Routine
{
    /// <summary>
    /// Representa la lista de rutina que tiene un robot.
    /// </summary>
    public class RoutineList : IEnumerable<Rut>, ICloneable
    {
        #region Fields
        /// <summary>
        /// Lista de rutinas.
        /// </summary>
        List<Rut> list;
        internal IProgrammable bot;
        #endregion

        #region Properties
        /// <summary>
        /// Cantidad de rutinas en la lista.
        /// </summary>
        public int Count => this.list.Count;



        /// <summary>
        /// Indexador de la lista de rutinas.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Rut this[int index]
        {
            get { return list[index]; }
            private set { list[index] = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construye una lista de rutinas vacía.
        /// </summary>
        public RoutineList( )
        {
            this.list = new List<Rut>( );
        }
        /// <summary>
        /// Construye una lista de rutinas a partir de un array de rutinas.
        /// </summary>
        /// <param name="list"></param>
        public RoutineList(params Rut[] list)
        {
            this.list = list.ToList<Rut>( );
        }
        #endregion

        #region Methods
        /// <summary>
        /// Carga una rutina de un .txt a esta lista.
        /// </summary>
        /// <param name="path">Path del .txt de la rutina.</param>
        /// <returns></returns>
        public void LoadRoutine(string path)
        {
            bool load = false;
            var rut = ControllerRoutine.LoadRoutine(path, out load);
            this.AddRoutine(rut);
        }

        /// <summary>
        /// Añadir una rutina a esta lista.
        /// </summary>
        /// <param name="routine">Array de rutinas que se desean añadir a la lista del robot.</param>
        public void AddRoutine(params Rut[] routine)
        {
            for ( int i = 0; i < routine.Length; i++ )
            {
                if ( routine[i].RobotRoutine == null )
                {
                    routine[i].RobotRoutine = this.bot;
                    routine[i].Index = list.Count;
                    this.list.Add(routine[i]);
                }
                else
                {
                    Rut routineCopy = (Rut) routine[i].Clone( );
                    routineCopy.RobotRoutine = this.bot;
                    routineCopy.Index = list.Count;
                    this.list.Add(routineCopy);
                }
            }

        }

        /// <summary>
        /// Remueve la rutina en la índice dado.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveRoutineAt(int index)
        {
            if ( index >= this.list.Count )
                throw new IndexOutOfRangeException("Ese índice no existe.");
            for ( int i = index + 1; i < list.Count; i++ )
                list[i].Index = i - 1;
            this.list.RemoveAt(index);
        }

        public IEnumerator<Rut> GetEnumerator( )
        {
            return list.GetEnumerator( );
        }
        IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );

        public object Clone( )
        {
            RoutineList listClone = new RoutineList( ) { bot = this.bot };

            foreach ( var item in this )
                listClone.AddRoutine((Rut) item.Clone( ));
            return listClone;
        }

        /// <summary>
        /// Ejecutar la lista de rutinas de un IProgrammable determinado.
        /// </summary>
        internal void Execute( )
        {
            //Robot sin rutinas
            if ( list.Count == 0 || list[0] == null )
            {
                //En dependencia de como el usuario quiera el control de errores se lanza un error o simplemente se imprime en la consola de la aplicacion el error.
                Errors.Error error = new Errors.Error("Robot sin rutinas o sin programa principal.");
                //El usuario no quiere errores, se acaba la simulacion.
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(bot,error);
                    return;
                }
                Simulator.WallE_Console.Print(bot,error.ToString( ));
                return;
            }
            //Si no hay rutinas en la pila de ejecucion de este robot, entonces apila la rutina con indice 0.
            if ( this.bot.ExecutingStack.Count == 0 )
            {
                var rut = (Rut) list[0].Clone( );
                rut.RobotRoutine = bot;
                ( (Robot) bot ).ExecutingStack.Push(rut);
            }
            //Se marca como que se esta ejecutando
            this.bot.ExecutingStack.Peek( ).Executing = true;
            //Se ejecuta hasta una accion fisica o que el flujo salga de la matriz.
            this.bot.ExecutingStack.Peek( ).Execute( );
            //Si al salir ha terminado de ejecutarse quitala del tope de la pila.
            if ( !bot.ExecutingStack.Peek( ).Executing )
                bot.ExecutingStack.Pop( );
        }
        /// <summary>
        /// Ejecuta la lista de rutinas del objeto IProgrammable instruccion por instruccion.
        /// </summary>
        /// <returns></returns>
        internal bool ExecuteByInstruction( )
        {
            /* Este metodo es parecido al de ejecutar hasta una accion fisica solo con la diferencia que lo que se ejecuta es un instruccion y se sale del metodo.
            Se devuelve un booleano para decir si con esa instruccion el objeto IProgrammable termina su turno.*/
            if ( list.Count == 0 || list[0] == null )
            {
                Errors.Error error = new Errors.Error("Robot sin rutinas o sin programa principal.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(bot,error);
                    return false;
                }
                Simulator.WallE_Console.Print(bot,error.ToString( ));
                return false;
            }
            if ( this.bot.ExecutingStack.Count == 0 )
            {
                var rut = (Rut) list[0].Clone( );
                rut.RobotRoutine = bot;
                ( (Robot) bot ).ExecutingStack.Push(rut);
            }

            this.bot.ExecutingStack.Peek( ).Executing = true;
            var returned = this.bot.ExecutingStack.Peek( ).ExecuteByInstruction( );
            if ( !bot.ExecutingStack.Peek( ).Executing )
                bot.ExecutingStack.Pop( );
            return returned;
        }
        #endregion
    }
}
