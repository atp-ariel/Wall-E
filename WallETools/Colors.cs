using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WallETools
{
    /// <summary>
    /// Representa todos los colores que pueden tener los objetos.
    /// </summary>
    public class Colors : EnumBaseType<Colors>
    {

        public readonly static Colors Transparent = new Colors("");
        public readonly static Colors Red = new Colors("");
        public readonly static Colors Yellow = new Colors("");
        public readonly static Colors Green = new Colors("");
        public readonly static Colors Blue = new Colors("");
        public readonly static Colors Brown = new Colors("");
        public readonly static Colors Black = new Colors("");
        public readonly static Colors White = new Colors("");

        public Colors(string value) : base(value)
        {
        }
        /// <summary>
        /// Devuelve una colección de todos los posible valores de colores.
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<Colors> GetValues( ) => GetBaseValues( );
        /// <summary>
        /// Devuelve un color por su identificador.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Colors GetByID(int id) => GetBaseByID(id);

        /// <summary>
        /// Cast explícito de integer a Color.
        /// </summary>
        /// <param name="id"></param>
        public static explicit operator Colors(int id) =>  GetBaseByID(id);

        /// <summary>
        /// Cast explicito de Colors a integer
        /// </summary>
        /// <param name="color"></param>
        public static explicit operator int (Colors color) => color.ID;
    }
}
}
