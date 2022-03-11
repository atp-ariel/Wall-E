using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WallETools
{
    /// <summary>
    /// Representa todos los tamaños que pueden tener los objetos.
    /// </summary>
    public class Sizes : EnumBaseType<Sizes>
    {
        public readonly static Sizes Empty = new Sizes("");
        public readonly static Sizes Small = new Sizes("");
        public readonly static Sizes Medium = new Sizes("");
        public readonly static Sizes Large = new Sizes("");

        public Sizes(string value) : base(value)
        {

        }
        /// <summary>
        /// Devuelve una colección de todos los posible valores de tamaños.
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<Sizes> GetValues( ) => GetBaseValues( );
        /// <summary>
        /// Devuelve un tamaño por su identificador.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Sizes GetByID(int id) => GetBaseByID(id);
        /// <summary>
        /// Cast explícito de integer a Size.
        /// </summary>
        /// <param name="id"></param>
        public static explicit operator Sizes(int id) => GetByID(id);

        /// <summary>
        /// Cast explicito de Size a integer
        /// </summary>
        /// <param name="size"></param>
        public static explicit operator int(Sizes size) => size.ID;
    }
}
