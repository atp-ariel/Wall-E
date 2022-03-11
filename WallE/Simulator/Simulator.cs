using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.World;
using WallE.Errors;

namespace WallE.Simulator
{
    public class Simulator : IEnumerable<Round>
    {
        #region Fields
        /// <summary>
        /// Mundo de la simulacion
        /// </summary>
        private Map world;
        /// <summary>
        /// Variable que guarda el estado inicial de la simulacion.
        /// </summary>
        private readonly Map initialWorldState;
        /// <summary>
        /// Enumerator de rondas.
        /// </summary>
        private IEnumerator<Round> enumerator;
        /// <summary>
        /// Tiempo entre rondas.
        /// </summary>
        double time;
        #endregion

        #region Properties
        /// <summary>
        /// Tiempo entre rondas.
        /// </summary>
        public double TimeSimulation
        {
            get
            {
                return time;
            }
            set
            {
                if ( value < 0.2 )
                    throw new ArgumentException("Valor de tiempo no valido. Debe ser mayor que 0.2 segundos");
                time = value;
            }
        }
        /// <summary>
        /// Se esta haciendo debug o no.
        /// </summary>
        public bool IsDebugging { get; private set; }
        /// <summary>
        /// Se desea permitir errores.
        /// </summary>
        public static bool NoAllowErrors { get; set; }
        public static Error CurrentError { get;  internal set; }
        /// <summary>
        /// Mundo de la simulacion.
        /// </summary>
        public Map World => this.world;

        /// <summary>
        /// Cantidad de rondas del simulador.
        /// </summary>
        public int Rounds { get; private set; }
        /// <summary>
        /// Se esta simulando en este momento.
        /// </summary>
        public bool IsRunning { get; /*private*/ set; }

        #endregion

        #region Constructor
        public Simulator(Map world)
        {
            this.world = world;

            this.initialWorldState = (Map) world.Clone( );
            foreach ( var item in initialWorldState )
                item.world = initialWorldState;

            GetEnumerator( );
        }

        #endregion

        #region Methods

        #region Execution
        /// <summary>
        /// Detiene la simulacion y la devuelve a su estado inicial.
        /// </summary>
        public virtual void Stop( )
        {
            this.IsDebugging = false;
            this.IsRunning = false;
            this.world = (Map) initialWorldState.Clone( );
            this.Rounds = 0;
            GetEnumerator( );
            Simulator.CurrentError = null;

        }
        /// <summary>
        /// Detiene la simulacion en la proxima ronda.
        /// </summary>
        public virtual void Pause( )
        {
            IsRunning = false;
            IsDebugging = false;
        }
        /// <summary>
        /// Avanza una ronda de la simulacion.
        /// </summary>
        public virtual void Advance( )
        {
            IsDebugging = false;
            IsRunning = true;

            if ( enumerator.MoveNext( ) )
            {
                enumerator.Current.Execute();
                this.Rounds++;
            }

            if ( Simulator.CurrentError != null && Simulator.NoAllowErrors )
                Stop( );

            IsRunning = false;
        }
        /// <summary>
        /// Hace la ejecucion instruccion por instruccion.
        /// </summary>
        public virtual void Debug( )
        {
            if ( !IsDebugging )
            {
                enumerator.MoveNext( );
                IsDebugging = enumerator.Current.ExecuteByInstruction( );
            }
            else
                IsDebugging = enumerator.Current.ExecuteByInstruction( );
            if ( !IsDebugging )
                this.Rounds++;
        }
        #endregion

        #region Auxiliar Methods
        /// <summary>
        /// Devuelve una ronda nueva.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Round> GetEnumerator( )
        {
            return enumerator = new SimulatorEnumerator(this.world.SelectIProgrammables( ));
        }
        IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );

        #endregion

        #endregion

        #region Events
        /// <summary>
        /// Metodo que reporta un error en la simulacion.
        /// </summary>
        /// <param name="robot">Objeto IProgrammable que tiene un error.</param>
        /// <param name="error"></param>
        public static void ReportError(IProgrammable robot,Errors.Error error)
        {
            CurrentError = error;
            Error(robot,new EventArgs( ));
        }
        /// <summary>
        /// Evento que se lanza cuando hay un error.
        /// </summary>
        public static event EventHandler Error;
        #endregion 
    }
}