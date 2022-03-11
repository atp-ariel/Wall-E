using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallETools
{
    /// <summary>
    /// Representa posiciones en un array bidimensional
    /// </summary>
    public class Position
    {
        #region Fields
        /// <summary>
        /// Representa las coordenadas de los ejes X.
        /// </summary>
        int x;
        /// <summary>
        /// Representa las coordenadas de los ejes Y.
        /// </summary>
        int y;
        #endregion

        #region Properties
        /// <summary>
        /// Representa las coordenadas de los ejes X.
        /// </summary>
        public int X
        {
            get { return this.x; }
            private set
            {
                if ( value < -1)
                    throw new ArgumentException("Coordenada X incorrecta.");
                this.x = value;
            }
        }
        /// <summary>
        /// Representa las coordenadas de los ejes Y.
        /// </summary>
        public int Y
        {
            get { return this.y; }
            private set
            {
                if ( value < -1)
                    throw new ArgumentException("Coordenada Y incorrecta.");
                this.y = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construye una posición correcta.
        /// </summary>
        /// <param name="axisX">Coordenada X.</param>
        /// <param name="axisY">Coordenada Y.</param>
        public Position(int axisX = 0,int axisY = 0)
        {
            this.X = axisX;
            this.Y = axisY;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Determina si un objeto es igual al Position actual.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is Position ) )
                return false;
            return this.X == ( (Position) obj ).X && this.Y == ( (Position) obj ).Y;
        }
        public override int GetHashCode( )
        {
            return base.GetHashCode( );
        }
        /// <summary>
        /// Devuelve el string que representa este Position.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            return this.X.ToString( ) + " " + this.Y.ToString( );
        }
        public Position FrontPosition(int direction)
        {
            return new Position(X + DirectionalArray.Row[direction],Y + DirectionalArray.Column[direction]);
        }
        public Position BackPosition(int directionInverse)
        {
            return new Position(X + DirectionalArray.Row[directionInverse != 2 ? directionInverse + 2 : directionInverse == 2 ? 0 : 1],
                                                    Y + DirectionalArray.Column[directionInverse != 2 ? directionInverse + 2 : directionInverse == 2 ? 0 : 1]);
        }
        #endregion
    }
}
