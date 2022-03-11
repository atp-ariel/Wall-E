using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace WallE.Tools
{
    /// <summary>
    /// Representa un enum de direcciones extensible
    /// </summary>
    public class Direction : EnumBaseType<Direction>
    {
        #region Fields
        public static readonly Direction North = new Direction("North");
        public static readonly Direction East = new Direction("East");
        public static readonly Direction South = new Direction("South");
        public static readonly Direction West = new Direction("West");
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
        public static Direction GetByID(int id) => GetBaseByID(id);
        /// <summary>
        /// Cast explícito de integer a Direction.
        /// </summary>
        /// <param name="direction"></param>
        public static explicit operator Direction(int direction) => GetByID(direction);
        /// <summary>
        /// Cast explicito de Direction a integer
        /// </summary>
        /// <param name="direction"></param>
        public static explicit operator int (Direction direction) => direction.ID;
        #endregion
    }
}
