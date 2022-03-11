using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallE.Tools
{
    /// <summary>
    ///Representa un array de direcciones.
    /// </summary>
    public static class DirectionalArray
    {
        private static List<Tuple<int,int>> Directional = new List<Tuple<int,int>>( )
        {
            Tuple.Create<int, int>(-1,0),
            Tuple.Create<int, int>(0,1),
            Tuple.Create<int, int>(1,0),
            Tuple.Create<int, int>(0,-1)
        };

        /// <summary>
        /// Metodo para añadir las coordenadas que describen la nueva direccion
        /// </summary>
        /// <param name="rowColumn"></param>
        public static void AddDirectional(Tuple<int,int> rowColumn) => Directional.Add(rowColumn);

        /// <summary>
        /// Indexador de la lista de direcciones.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static Tuple<int,int> Indexer(int index) => Directional[index];
    }
}
