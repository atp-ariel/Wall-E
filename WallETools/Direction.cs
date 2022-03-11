using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallETools
{
    /// <summary>
    /// Representa un enum de direcciones extensible
    /// </summary>
    public class Direction : EnumBaseType<Direction>
    {
        #region Fields
        public static readonly Direction North = new Direction("north");
        public static readonly Direction East = new Direction("east");
        public static readonly Direction South = new Direction("south");
        public static readonly Direction West = new Direction("west");
        #endregion

        #region Constructor
        public Direction(string value) : base(value) { }
        #endregion

        #region Methods
        /// <summary>
        /// Devuelve una colección de todas las direcciones.
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<Direction> GetValues( ) => GetBaseValues( );
        /// <summary>
        /// Devuelve una dirección por su ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Direction GetByID(byte id) => GetBaseByID(id);
        /// <summary>
        /// Cast explícito de integer a Direction.
        /// </summary>
        /// <param name="direction"></param>
        public static explicit operator Direction(byte direction) => GetByID(direction);
        /// <summary>
        /// Cast explicito de Direction a integer
        /// </summary>
        /// <param name="direction"></param>
        public static explicit operator int (Direction direction) => direction.ID;
    }
    #endregion
}
}
