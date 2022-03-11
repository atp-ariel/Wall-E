using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;

namespace WallE.World.WorldObjects
{
    /// <summary>
    /// Objeto Caja.
    /// </summary>
    public class Box : WallEObjects
    {
        #region Properties
        public override bool IsLoad => this.ObjSize == (int)Sizes.Small;

        public override bool IsObstacle => this.ObjSize != (int) Sizes.Small;
        
        #endregion
        #region Constructors
        /// <summary>
        /// Construye una instancia de una caja.
        /// </summary>
        /// <param name="number">ID de la caja.</param>
        /// <param name="size">Tamaño de la caja.</param>
        /// <param name="color">Color de la caja.</param>
        public Box(Position position, ref Map world, int size = 2,int color = 1) : base(2,size,color, position, ref world) { }
        public Box( int size = 2, int color = 1 ) : base(2, size, color)
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Devuelve el string que representa esta caja.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            return base.ToString( );
        }
        /// <summary>
        /// Determina si un objeto específico es igual a la instancia.
        /// </summary>
        /// <param name="obj">Objeto a comparar.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is Box ) )
                return false;
            return this.Equals(obj as Box);
        }
        /// <summary>
        /// Determina si dos cajas son iguales.
        /// </summary>
        /// <param name="bx">Caja a comparar.</param>
        /// <returns></returns>
        private bool Equals(Box bx)
        {
            return ( this.ObjSize == bx.ObjSize && this.ObjColor == bx.ObjColor && this.ObjNumber == bx.ObjNumber );
        }
        public override int GetHashCode( )
        {
            return base.GetHashCode( );
        }

        /// <summary>
        /// Devuelve un clon de esta caja.
        /// </summary>
        /// <returns></returns>
        public override object Clone( )
        {
            return new Box(this.ObjSize,this.ObjColor) { ObjNumber = this.ObjNumber};
        }

        public override bool IsMovable(Direction direction)
        {
            Position frontPosition = ObjPosition.FrontPosition(direction.ID);

            return Map.IsValidPosition(world,frontPosition) && this.world[frontPosition] == null;
        }

        #endregion
    }
}
