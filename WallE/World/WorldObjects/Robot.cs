using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.Routine;
using WallE.Simulator;

namespace WallE.World.WorldObjects
{
    public class Robot : WallEObjects, ISensitive, IProgrammable, ILoader
    {
        #region Fields
        public override string MainCharacteristics => (Shapes) this.ObjShape + "_" + (Colors) this.ObjColor;

        /// <summary>
        /// Representa el objeto embebido en el interior del robot.
        /// </summary>
        WallEObjects objectsInside;

        /// <summary>
        /// Representa la pila del robot.
        /// </summary>
        public Stack<int> Stack { get; set; }

        /// <summary>
        /// Representa la pila de rutinas que se van ejecutando en la simulación del mundo.
        /// </summary>
        public Stack<Rut> ExecutingStack { get; set; }

        /// <summary>
        /// Representa la memoria lineal del robot.
        /// </summary>
        public LinealMemory Memory { get; set; }

        /// <summary>
        /// Cantidad de rondas de simulación del robot.
        /// </summary>
        int time;
        #endregion

        #region Properties
        /// <summary>
        /// Representa la lista de rutinas del robot.
        /// </summary>
        public RoutineList ListRoutine { get; set; }

        /// <summary>
        /// Cantidad de rondas de simulación del robot.
        /// </summary>
        public int Times
        {
            get
            { return time; }
            set
            {
                if ( value < 0 )
                    throw new ArgumentException("Ronda inválida.");
                this.time = value;
            }
        }

        /// <summary>
        /// Determina la dirección del robot en el mundo.
        /// </summary>
        public int Directions { get; set; }

        /// <summary>
        /// Representa el objeto que esta en el interior del robot.
        /// </summary>
        public WallEObjects ObjectInside
        {
            get { return this.objectsInside; }
            set
            {
                if ( value is IProgrammable )
                    throw new InvalidOperationException("Un robot no puede cargar a otro objeto programable. En este caso a: " + value.ToString( ) + ".");
                this.objectsInside = value;
            }
        }

        /// <summary>
        /// Determina si este objeto es un obstaculo
        /// </summary>
        public override bool IsObstacle => true;

        public override bool IsLoad => false;


        #endregion

        #region Constructors
        /// <summary>
        /// Construye una instacia de un robot.
        /// </summary>
        /// <param name="number">ID del robot.</param>
        /// <param name="List">Lista de rutinas del robot.</param>
        /// <param name="direction">Dirección del robot en el mundo.</param>
        public Robot(Position position,ref Map world,int direction = 1,int color = 1) : base(4,3,color,position,ref world)
        {
            this.ListRoutine = new RoutineList( );
            this.ListRoutine.bot = this;
            this.Directions = direction;
            this.Memory = new LinealMemory( );
            this.Stack = new Stack<int>( );
            this.ExecutingStack = new Stack<Rut>( );
            this.time = 0;
        }

        public Robot(int direction = 1,int color = 1) : base(4,3,color)
        {
            this.ListRoutine = new RoutineList( );
            this.ListRoutine.bot = this;
            this.Directions = direction;
            this.Memory = new LinealMemory( );
            this.Stack = new Stack<int>( );
            this.ExecutingStack = new Stack<Rut>( );
            this.time = 0;
        }
        #endregion

        #region Methods
        #region Implement of ISensor
        /// <summary>
        /// Apila la dirección del robot en el mundo.
        /// </summary>
        public void Direction( )
        {
            try { this.Stack.Push(Directions); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("La pila está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public void Time( )
        {
            try { this.Stack.Push(Times); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("La pila está llena, por tanto no podrá añadir ese valor."));
            }
        }
        /// <summary>
        /// Distancia del robot al objeto más cercano o a los bordes del mundo.
        /// </summary>
        /// <returns></returns>
        public void Distance( )
        {
            try { this.Stack.Push(this.world.ObjectMoreNear(this)); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("La pila está llena, por tanto no podrá añadir ese valor."));
            }
        }
        /// <summary>
        /// Determina el color del objeto enfrente del robot.
        /// </summary>
        public void Color( ) {
            try
            { this.Stack.Push(this.world.ColorScanner(this)); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("La pila está llena, por tanto no podrá añadir ese valor."));
            }
        }
        /// <summary>
        /// Apila la forma del objeto enfrente.
        /// </summary>
        public void Shape( ) {
            try
            { this.Stack.Push(this.world.ShapeScanner(this)); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("La pila está llena, por tanto no podrá añadir ese valor."));
            }
        }
        /// <summary>
        /// Detemrmina el ID del objeto enfrente.
        /// </summary>
        public void Code( ) {
            try
            { this.Stack.Push(this.world.Scanner(this)); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("La pila está llena, por tanto no podrá añadir ese valor."));
            }
        }
        /// <summary>
        /// Determina si este robot tiene un objeto en su interior.
        /// </summary>
        public void Loaded( )
        {
            try {
                if ( this.ObjectInside == null )
                    this.Stack.Push(0);
                this.Stack.Push(1); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(this,new Errors.Error("La pila está llena, por tanto no podrá añadir ese valor."));
            }
        }
        #endregion

        #region Basic type
        /// <summary>
        /// Devuelve el string de una instancia de un robot.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            return (Shapes) this.ObjShape + " " + this.ObjNumber + " " + (Colors) this.ObjColor + " " + (Direction) this.Directions;
        }
        /// <summary>
        /// Determina si la instacia del robot es igual a otro objeto.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is Robot ) )
                return false;
            return this.Equals(obj as Robot);
        }
        private bool Equals(Robot robot) => this.ObjNumber == robot.ObjNumber;
        public override int GetHashCode( )
        {
            return 7 * this.ObjNumber;
        }
        public override object Clone( )
        {
            Robot robotClone = new Robot(this.Directions);
            robotClone.ObjColor = this.ObjColor;
            robotClone.ObjNumber = this.ObjNumber;
            if ( this.ObjectInside != null )
                robotClone.ObjectInside = (WallEObjects) this.ObjectInside.Clone( );
            robotClone.Memory = (LinealMemory) this.Memory.Clone( );
            robotClone.ListRoutine = (RoutineList) this.ListRoutine.Clone( );
            robotClone.ListRoutine.bot = robotClone;

            return robotClone;
        }
        #endregion
        #endregion

        #region Physic methods
        public virtual void Back( )
        {
            Position backPosition = ObjPosition.BackPosition(this.Directions);

            if ( this.IsMovable((Direction) ( Directions == 2 ? 0 : Directions == 3 ? 1 : Directions + 2 )) )
            {
                this.world.MoveObjectTo(ObjPosition,backPosition);
                this.ObjPosition = backPosition;
            }
        }
        public virtual void Advance( )
        {
            Position frontPosition = ObjPosition.FrontPosition(Directions);

            if ( !IsMovable((Direction) Directions) )
                return;
            //Si no hay nadie enfrente
            if ( world[frontPosition] == null )
                world.MoveObjectTo(ObjPosition,frontPosition);
            //Si lo que esta enfrente es cargable y el robot esta vacio
            else if ( this.world[frontPosition].IsLoad && this.ObjectInside == null )
            {
                this.world.RemoveAt(frontPosition,out this.objectsInside);
                this.world.MoveObjectTo(ObjPosition,frontPosition);
            }
            //Si lo que esta enfrente es una bola movible avanza
            else if ( this.world[frontPosition] is Sphere && this.world[frontPosition].IsMovable((Direction) Directions) )
            {
                Position lastEmptyPosition;

                if ( world.InLineSphere(frontPosition,Directions,out lastEmptyPosition) )
                {
                    Position tempObjPosition = (Position) ObjPosition.Clone( );
                    while ( !lastEmptyPosition.Equals(tempObjPosition) )
                    {
                        world.MoveObjectTo(lastEmptyPosition.BackPosition(Directions),lastEmptyPosition);
                        lastEmptyPosition = lastEmptyPosition.BackPosition(Directions);
                    }
                }
            }
            //Si lo que esta enfrente es un objeto que no se puede mover o que es un obstaculo por sus caracteristicas propias no se avanza
            else if ( ( this.ObjectInside != null && this.world[frontPosition].IsLoad )
                || this.world[frontPosition].IsObstacle )
                return;
            //Si lo que esta enfrente es movible entonces avanza.
            else if ( this.world[frontPosition].IsMovable((Direction) Directions) )
            {
                world.MoveObjectTo(frontPosition,frontPosition.FrontPosition(Directions));
                world.MoveObjectTo(ObjPosition,frontPosition);
            }
            else return;
        }
        public void Drop( )
        {
            Position frontPosition = ObjPosition.FrontPosition(Directions);

            if ( Map.IsValidPosition(world,frontPosition) )
                //Si tiene algo en su interior y la posicion de enfrente esta vacia lo suelta...
                if ( this.ObjectInside != null && world[frontPosition] == null )
                {
                    //Si el objeto nunca estuvo en el mundo entonces añadele un id (caso en que un robot comience con un objeto dentro.
                    if ( this.ObjectInside.ObjNumber == 0 )
                        this.ObjectInside.ObjNumber = this.world.CountObjects++;
                    //Suelta el objeto en su interior enfrente...
                    world.InsertOldObjectAt(this.ObjectInside,frontPosition);
                    this.ObjectInside = null;
                }
        }
        public override bool IsMovable(Direction direction)
        {
            Position frontPosition = ObjPosition.FrontPosition(direction.ID);

            return Map.IsValidPosition(world,frontPosition) && ( world[frontPosition] == null || world[frontPosition].IsMovable(direction) );
        }
        #endregion
    }
}

