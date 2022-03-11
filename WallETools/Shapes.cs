using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallETools
{
    /// <summary>
 /// Representa todas las formas que pueden tener los objetos.
 /// </summary>
    public class Shapes : EnumBaseType<Shapes>
    {
        #region Fields
        public static readonly Shapes Nothing = new Shapes(" ");
        public static readonly Shapes Sphere = new Shapes("S");
        public static readonly Shapes Box = new Shapes("B");
        public static readonly Shapes Plant = new Shapes("P");
        public static readonly Shapes Robot = new Shapes("R");
        #endregion

        #region Constructor
        public Shapes(string value) : base(value) { }
        #endregion

        #region Methods
        /// <summary>
        /// Devuelve una colección de todos los posible valores de formas.
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<Shapes> GetValues( ) => GetBaseValues( );
        /// <summary>
        /// Devuelve una forma por su identificador.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Shapes GetByID(int id) => GetBaseByID(id);
        /// <summary>
        /// Cast explícito de integer a Shape.
        /// </summary>
        /// <param name="id"></param>
        public static explicit operator Shapes(int id) => (Shapes) GetByID(id);
        /// <summary>
        /// Cast explicito de Shapes a integer
        /// </summary>
        /// <param name="shape"></param>
        public static explicit operator int (Shapes shape) => shape.ID;
    }
    #endregion
}
}
