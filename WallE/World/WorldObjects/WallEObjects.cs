using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.World.WorldObjectsFactory;

namespace WallE.World.WorldObjects
{
    public abstract class WallEObjects : ICloneable, ILoad, IMovable, IObstacle
    {

        #region Fields
        /// <summary>
        /// Forma del objeto.
        /// </summary>
        private int objShape;
        /// <summary>
        /// Tamaño del objeto.
        /// </summary>
        private int objSize;
        /// <summary>
        /// Color del objeto.
        /// </summary>
        private int objColor;

        internal Map world;
        #endregion

        #region Properties
        public virtual string MainCharacteristics => (Shapes)this.ObjShape + "_" + (Sizes) this.ObjSize +"_"+(Colors)this.ObjColor;

        /// <summary>
        /// ID del objeto.
        /// </summary>
        public int ObjNumber
        {
            get; internal set;
        }
        public int ObjShape
        {
            get
            {
                return objShape;
            }
            set
            {
                if ( value > Shapes.GetValues( ).Skip(1).Select(c => c.ID).Max( ) || value < Shapes.GetValues( ).Skip(1).Select(c => c.ID).Min( ) )
                    throw new InvalidOperationException("Forma invalida");
                objShape = value;
            }
        }
        public int ObjSize
        {
            get
            {
                return objSize;
            }
            set
            {
                if ( value > Sizes.GetValues( ).Skip(1).Select(c => c.ID).Max( ) || value < Sizes.GetValues( ).Skip(1).Select(c => c.ID).Min( ) )
                    throw new InvalidOperationException("Forma invalida");
                objSize = value;
            }
        }
        public int ObjColor
        {
            get
            {
                return objColor;
            }
            set
            {
                if ( value > Colors.GetValues( ).Skip(1).Select(c => c.ID).Max( ) || value < Colors.GetValues( ).Skip(1).Select(c => c.ID).Min( ) )
                    throw new InvalidOperationException("Forma invalida");
                objColor = value;
            }
        }
        /// <summary>
        /// Posicion del objeto en el mundo.
        /// </summary>
        public Position ObjPosition
        {
            get; set;
        }

        public virtual bool IsObstacle { get; }

        public virtual bool IsLoad { get; }

        #endregion

        #region Constructor
        /// <summary>
        /// Construye un objeto del mundo Wall-E y lo añade al mundo.
        /// </summary>
        /// <param name="shape">Forma del objeto.</param>
        /// <param name="size">Tamaño del objeto.</param>
        /// <param name="color">Color del objeto.</param>
        /// <param name="number">ID del objeto.</param>
        public WallEObjects(int shape,int size,int color,Position position,ref Map world) : this(shape,size,color)
        {
            this.world = world;
            this.ObjPosition = position;
            try
            {
                this.world.AddNewObjectAt(this);
            }
            catch ( Exception )
            {
                throw;
            }

        }

        public WallEObjects(int shape,int size,int color)
        {
            if ( IsValidParameters(shape,size,color) )
            {
                this.ObjShape = shape;
                this.ObjSize = size;
                this.ObjColor = color;
            }
            else
                throw new InvalidOperationException("Parámetros inválidos.");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Devuelve el string que representa un objeto.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            return (Shapes) this.ObjShape + " " + this.ObjNumber + " " +(Sizes)this.ObjSize + " "+(Colors)this.ObjColor;
        }
        /// <summary>
        /// Determina si la instancia es igual a un WallEObjects específico
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is WallEObjects ) )
                return false;
            return this.ObjNumber == ( (WallEObjects) obj ).ObjNumber;
        }
        public override int GetHashCode( )
        {
            return base.GetHashCode( );
        }
        public abstract object Clone( );
        public void AddWorld(ref Map world)
        {
            if ( this.world == null )
                this.world = world;
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Determina si estos parámetros son válidos para construir un objeto.
        /// </summary>
        /// <param name="shape">Forma del objeto.</param>
        /// <param name="size">Tamaño del objeto.</param>
        /// <param name="color">Color del objeto.</param>
        /// <param name="number">ID del objeto.</param>
        /// <returns></returns>
        private static bool IsValidParameters(int shape,int size,int color)
        {
            if ( shape == 0 || size == 0 || color == 0 )
                return false;
            return true;
        }

        public abstract bool IsMovable(Direction direction);

        private static Dictionary<string,WallEObjectsFactory> factories;

        public static WallEObjects ExecuteCreation(string nameWallEObjects)
        {
            if ( factories == null )
            {
                factories = new Dictionary<string,WallEObjectsFactory>( );

                foreach ( var item in Shapes.GetValues( ).Skip(1) )
                {
                    var factory = (WallEObjectsFactory) Activator.CreateInstance(Type.GetType("WallE.World.WorldObjectsFactory." + item.Value + "Factory"));

                    factories.Add(item.Value,factory);
                }
            }

            if ( !factories.ContainsKey(nameWallEObjects) )
                throw new InvalidOperationException("Instruccion inexistente.");

            return factories[nameWallEObjects].Create( );
        }
        #endregion
    }
}
