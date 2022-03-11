using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallE.Tools
{
    /// <summary>
    /// Conjunto de sensores que puede implementar un objeto.
    /// </summary>
    public interface ISensitive
    {
        /// <summary>
        /// Determina la cantidad de espacios vacíos desde el frente del objeto hasta el más cercano o hasta el fin del terreno.
        /// </summary>
        /// <returns></returns>
        void Distance( );
        /// <summary>
        /// Determina el color del objeto enfrente del objeto.
        /// </summary>
        void Color( );
        /// <summary>
        /// Determina la forma del objeto en frente al que implemente la interface.
        /// </summary>
        void Shape( );
        /// <summary>
        /// Determina el ID del objeto en frente al que implemente la interface.
        /// </summary>
        void Code( );
        /// <summary>
        /// Determina si el objeto tiene otro en su interior.
        /// </summary>
        void Loaded( );
        /// <summary>
        /// Determina la cantidad de rondas de simulación.
        /// </summary>
        void Time( );
        /// <summary>
        /// Determina la dirección del objeto en el mundo
        /// </summary>
        void Direction( );
    }
}
