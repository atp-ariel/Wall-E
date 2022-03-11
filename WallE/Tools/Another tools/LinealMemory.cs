using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallE.Tools
{
    /// <summary>
    /// Representa la memoria lineal.
    /// </summary>
    public class LinealMemory : ICloneable
    {
        /// <summary>
        /// Array que representa la memoria lineal.
        /// </summary>
        int[] memory;

        /// <summary>
        /// Construye una memoria lineal.
        /// </summary>
        public LinealMemory( )
        {
            this.memory = new int[1000000];
        }

        /// <summary>
        /// Indexador de la memoria lineal.
        /// </summary>
        /// <param name="index">Indice de la memoria lineal.</param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                if ( index < 0 || index >= 1000000 )
                    throw new IndexOutOfRangeException("Índicie fuera de rango de la memoria lineal.");
                return this.memory[index];
            }
            internal set
            {
                if ( index < 0 || index >= 1000000 )
                    throw new IndexOutOfRangeException("Índicie fuera de rango de la memoria lineal.");
                this.memory[index] = value;
            }
        }

        /// <summary>
        /// Devuelve una nueva memoria lineal.
        /// </summary>
        /// <returns></returns>
        public object Clone( )
        {
            LinealMemory memoryClone = new LinealMemory( );

            for ( int i = 0; i < this.memory.Length; i++ )
                memoryClone[i] = this.memory[i];

            return memoryClone;
        }
    }
}
