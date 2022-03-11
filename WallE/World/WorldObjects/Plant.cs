using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;

namespace WallE.World.WorldObjects
{
    /// <summary>
    /// Planta de Wall-E
    /// </summary>
    public class Plant : WallEObjects
    {

        #region Properties
        public override bool IsLoad => this.ObjSize == (int) Sizes.Small;

        public override bool IsObstacle => this.ObjSize != (int) Sizes.Small;
        #endregion

        #region Constructors
        /// <summary>
        /// Construye una instancia de planta verde.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="size"></param>
        public Plant(Position position, ref Map world, int size = 2, int color = 3) : base(3,size,color, position, ref world)
        {

        }
        public Plant(int size = 2, int color = 3 ) : base(3, size, color)
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Devuelve el string que representa una instancia de una planta.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            return base.ToString( );
        }
        /// <summary>
        /// Determina si una planta es igual a un objeto específico.
        /// </summary>
        /// <param name="obj">Objeto a comparar.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is Plant ) )
                return false;
            return ( this.ObjSize == ( (Plant) obj ).ObjSize && this.ObjColor == ( (Plant) obj ).ObjColor && this.ObjNumber == ( (Plant) obj ).ObjNumber );
        }

        public override int GetHashCode( )
        {
            return base.GetHashCode( );
        }
        /// <summary>
        /// Devuelve un clon de esta planta.
        /// </summary>
        /// <returns></returns>
        public override object Clone( )
        {
            return new Plant(this.ObjSize) { ObjNumber = this.ObjNumber };
        }

        public override bool IsMovable(Direction direction)
        {
            if ( !IsObstacle )
            {
                Position frontPosition = ObjPosition.FrontPosition(direction.ID);

                return Map.IsValidPosition(world,frontPosition) && this.world[frontPosition] == null;
            }
            return false;
        }

        #endregion
    }
}
