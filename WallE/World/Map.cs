using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.World.WorldObjects;
using System.Collections;

namespace WallE.World
{
    /// <summary>
    /// Representa el mapa del mundo Wall-E
    /// </summary>
    public class Map : IEnumerable<WallEObjects>, ICloneable
    {
        #region Fields

        /// <summary>
        /// Representa el mapa.
        /// </summary>
        private WallEObjects[,] map;
        #endregion

        #region Properties
        /// <summary>
        /// Cantidad de objetos.
        /// </summary>
        public int CountObjects { get; set; }

        /// <summary>
        /// Representa la cantidad de filas del mapa.
        /// </summary>
        public int Rows => this.map.GetLength(0);

        /// <summary>
        /// Representa la cantidad de columnas del mapa.
        /// </summary>
        public int Columns => this.map.GetLength(1);

        /// <summary>
        /// Indexador del mapa
        /// </summary>
        /// <param name="position">Posición a indexar.</param>
        /// <returns></returns>
        public WallEObjects this[Position position]
        {
            get
            {
                if ( !IsValidPosition(this,position) )
                    throw new InvalidOperationException("Posicion invalida.");
                return this.map[position.X,position.Y];
            }
        }

        /// <summary>
        /// Indexador del mapa
        /// </summary>
        /// <param name="indexRow">Fila a indexar.</param>
        /// <param name="indexColumn">Columna a indexar.</param>
        /// <returns></returns>
        public WallEObjects this[int indexRow, int indexColumn] => this[new Position(indexRow,indexColumn)];
        #endregion

        #region Constructor
        /// <summary>
        /// Construye la instancia de un mapa.
        /// </summary>
        /// <param name="rows">Cantidad de filas. Por defecto 10</param>
        /// <param name="columns">Cantidad de columnas. Por defecto 20.</param>
        public Map(int row = 10,int columns = 20) : this(null,row,columns) { }

        /// <summary>
        /// Construye la instancia de un mapa.
        /// </summary>
        /// <param name="knowObjectsPosition">Objetos que tiene una posición conocida.</param>
        /// <param name="rows">Cantidad de filas.</param>
        /// <param name="columns">Cantidad de columnas.</param>
        public Map(Tuple<WallEObjects,Position>[] knowObjectsPosition,int rows = 10,int columns = 20)
        {
            if ( rows <= 0 || columns <= 0 )
                throw new ArgumentException("Parámetros inválidos.");
            this.map = new WallEObjects[rows, columns];

            if ( knowObjectsPosition != null )
                this.map = FillWith(map,knowObjectsPosition);
        }
        #endregion

        #region Methods

        #region Controller Wall-E Objects

        /// <summary>
        /// Añade un objeto nuevo en la posicion.
        /// </summary>
        /// <param name="objects">Nuevo objeto.</param>
        /// <param name="position"></param>
        public void AddNewObjectAt(WallEObjects objects)
        {
            if ( !IsValidPosition(this,objects.ObjPosition) )
                throw new InvalidOperationException("No puede añadir un objeto en una posicion incorrecta.");
            if ( !CanAddAt(objects.ObjPosition) )
                throw new InvalidOperationException("Posicion ocupada en el mapa.");

            this.map[objects.ObjPosition.X,objects.ObjPosition.Y] = objects;
            var tempWorld = this;
            objects.AddWorld(ref tempWorld);
            objects.ObjNumber = ++this.CountObjects;
        }
        /// <summary>
        /// Remueve el objeto de una posición determinada.
        /// </summary>
        /// <param name="position">Posición determinada.</param>
        public void RemoveAt(Position position,out WallEObjects objects)
        {
            if ( !IsValidPosition(this,position) )
                throw new ArgumentException("Posicion incorrecta.");
            objects = this.map[position.X,position.Y];
            if ( objects == null )
                return;
            objects.ObjPosition = new Position(-1,-1);
            this.map[position.X,position.Y] = null;
            this.CountObjects--;
        }
        /// <summary>
        /// Mueve el objeto de la posicion inicial hasta la posicion final.
        /// </summary>
        /// <param name="posInitial"></param>
        /// <param name="posEnd"></param>
        internal void MoveObjectTo(Position posInitial,Position posEnd)
        {
            if ( !IsValidPosition(this,posInitial) || !IsValidPosition(this,posEnd) )
                throw new InvalidOperationException("Posiciones incorrectas.");

            WallEObjects tempObject;
            RemoveAt(posInitial,out tempObject);
            InsertOldObjectAt(tempObject,posEnd);
        }

        #endregion

        #region Auxiliar Methods

        /// <summary>
        /// Añade un objeto en una posición del mapa.
        /// </summary>
        /// <param name="wallEObject">Objeto a añadir.</param>
        /// <param name="position">Posición donde se desea añadir.</param>
        internal void InsertOldObjectAt(WallEObjects wallEObject,Position position)
        {
            if ( IsValidPosition(this,position) && CanAddAt(position) )
            {
                this.map[position.X,position.Y] = wallEObject;
                wallEObject.ObjPosition = position;
            }
            else
                throw new InvalidOperationException("No puede añadir un objeto en esa posición.");
        }

        /// <summary>
        /// Determina si puede añadirse un WallE objects en una determinada posicion en el mapa.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private bool CanAddAt(Position position)
        {
            return this[position] == null;
        }
        /// <summary>
        /// Devuelve un clon de este mapa.
        /// </summary>
        /// <returns></returns>
        public object Clone( )
        {
            Map mapClone = new Map(this.Rows,this.Columns);
            for ( int i = 0; i < this.Rows; i++ )
                for ( int j = 0; j < this.Columns; j++ )
                    if ( this[i,j] != null )
                    {
                        WallEObjects objectTemp = (WallEObjects) this[i,j].Clone( );
                        objectTemp.AddWorld(ref mapClone);
                        mapClone.InsertOldObjectAt(objectTemp,new Position(i,j));
                    }
            return mapClone;
        }
        /// <summary>
        /// Devuelve el identificador del objeto que esta enfrente.
        /// </summary>
        /// <param name="bot"></param>
        /// <returns></returns>
        public int Scanner(IProgrammable bot)
        {
            if ( bot is ISensitive ) //Borre el 'bot is WallEObjects'
            {
                if ( !Map.IsValidPosition(this,( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)) )
                    return 0;
                if ( this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)] == null )
                    return 0;
                return this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)].ObjNumber;
            }
            throw new InvalidOperationException("Este objeto no implementa este sensor.");
        }
        /// <summary>
        /// Devuelve la cantidad de casillas libres en el mundo hasta el objeto mas cercano o hasta el mundo.
        /// </summary>
        /// <param name="bot"></param>
        /// <returns></returns>
        public int ObjectMoreNear(IProgrammable bot)
        {
            if ( bot is ISensitive ) //Borre el 'bot is WallEObjects'
            {
                int countEmptyPosition = 0;

                for ( Position frontPosition = ( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions);
                        Map.IsValidPosition(this,frontPosition) && this[frontPosition] == null;
                            frontPosition = frontPosition.FrontPosition(bot.Directions) )
                    countEmptyPosition++;

                return countEmptyPosition;
            }
            throw new InvalidOperationException("Este objeto no implementa este sensor.");
        }
        /// <summary>
        /// Devuelve la forma del objeto que esta enfrente.
        /// </summary>
        /// <param name="bot"></param>
        /// <returns></returns>
        public int ShapeScanner(IProgrammable bot)
        {
            if ( bot is ISensitive ) //Borre el 'bot is WallEObjects'
            {
                if ( !Map.IsValidPosition(this,( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)) )
                    return 0;
                if ( this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)] == null )
                    return 0;

                return this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)].ObjShape;
            }
            throw new InvalidOperationException("Este objeto no implementa este sensor.");
        }
        /// <summary>
        /// Devuelve el color del objeto que esta enfrente.
        /// </summary>
        /// <param name="bot"></param>
        /// <returns></returns>
        public int ColorScanner(IProgrammable bot)
        {
            if ( bot is ISensitive )
            {

                if ( !Map.IsValidPosition(this,( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)) )
                    return 0;
                if ( this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)] == null )
                    return 0;

                return this[( (WallEObjects) bot ).ObjPosition.FrontPosition(bot.Directions)].ObjColor;
            }
            throw new InvalidOperationException("Este objeto no implementa este sensor.");
        }
        #endregion

        #region Basic type methods
        /// <summary>
        /// Determina si un objeto es igual al mundo actual.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is Map ) )
                return false;
            if ( this.map.GetLength(0) != ( (Map) obj ).map.GetLength(0) || this.map.GetLength(1) != ( (Map) obj ).map.GetLength(1) )
                return false;

            for ( int i = 0; i < this.map.GetLength(0); i++ )
                for ( int j = 0; j < this.map.GetLength(1); j++ )
                    if ( !this.map[i,j].Equals(( (Map) obj ).map[i,j]) )
                        return false;
            return true;
        }
        /// <summary>
        /// Devuelve el codigo hash de este objeto.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode( )
        {
            int i = 0;
            foreach ( var item in this )
                i += ( item.GetHashCode( ) / ( Rows + Columns ) );
            return i;
        }

        /// <summary>
        /// Devuelve el string que representa el mundo.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            string mapString = string.Empty;
            for ( int i = 0; i < this.map.GetLength(0); i++ )
            {
                for ( int j = 0; j < this.map.GetLength(1); j++ )
                {
                    if ( map[i,j] == null )
                        mapString += "-";
                    else
                        mapString += this.map[i,j].ToString( );
                    mapString += "\t" + "||" + "\t";
                }
                mapString += "\n";
            }
            return mapString;
        }
        #endregion

        #region Map Methods
        ///<summary>
        /// Añade una fila al final de la matriz.
        /// </summary>
        public void AddLastRow( )
        {
            AddRowAt(this.Rows);
        }
        /// <summary>
        /// Añade una columna al final de la matriz.
        /// </summary>
        public void AddLastColumn( )
        {
            AddColumnAt(this.Columns);
        }

        /// <summary>
        /// Añade una fila al inicio de la matriz.
        /// </summary>
        private void AddFirstRow( )
        {
            WallEObjects[,] result = new WallEObjects[this.Rows + 1, this.Columns];

            for ( int i = 1; i < result.GetLength(0); i++ )
                for ( int j = 0; j < result.GetLength(1); j++ )
                    if ( this.map[i - 1,j] != null )
                    {
                        result[i,j] = this.map[i - 1,j];
                        result[i,j].ObjPosition = new Position(i,j);
                    }
            this.map = result;
        }
        /// <summary>
        /// Añade una columna al inicio de la matriz.
        /// </summary>
        private void AddFirstColumn( )
        {
            WallEObjects[,] result = new WallEObjects[this.Rows, this.Columns + 1];

            for ( int i = 0; i < result.GetLength(0); i++ )
                for ( int j = 1; j < result.GetLength(1); j++ )
                    if ( this.map[i,j - 1] != null )
                    {
                        result[i,j] = this.map[i,j - 1];
                        result[i,j].ObjPosition = new Position(i,j);
                    }
            this.map = result;
        }
        /// <summary>
        /// Añade una fila en el índice.
        /// </summary>
        /// <param name="index"></param>
        public void AddRowAt(int index)
        {
            if ( index < 0 )
                AddFirstRow( );
            else
            {
                WallEObjects[,] result;
                if ( index < this.Rows )
                {
                    result = new WallEObjects[this.Rows + 1, this.Columns];

                    for ( int i = 0; i < index; i++ )
                        for ( int j = 0; j < result.GetLength(1); j++ )
                            if ( this.map[i,j] != null )
                            {
                                result[i,j] = this.map[i,j];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                    for ( int i = index + 1; i < result.GetLength(0); i++ )
                        for ( int j = 0; j < result.GetLength(1); j++ )
                            if ( this.map[i - 1,j] != null )
                            {
                                result[i,j] = this.map[i - 1,j];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                }
                else
                {
                    result = new WallEObjects[index + 1, this.Columns];

                    for ( int i = 0; i < this.Rows; i++ )
                        for ( int j = 0; j < this.Columns; j++ )
                            if ( this.map[i,j] != null )
                            {
                                result[i,j] = this.map[i,j];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                }
                this.map = result;
            }
        }

        /// <summary>
        /// Añade una columna en el índice.
        /// </summary>
        /// <param name="index"></param>
        public void AddColumnAt(int index)
        {
            if ( index < 0 )
                AddFirstColumn( );
            else
            {
                WallEObjects[,] result;
                if ( index < this.Columns )
                {
                    result = new WallEObjects[this.Rows, this.Columns + 1];

                    for ( int i = 0; i < result.GetLength(0); i++ )
                        for ( int j = 0; j < index; j++ )
                            if ( this.map[i,j] != null )
                            {
                                result[i,j] = this.map[i,j];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                    for ( int i = 0; i < result.GetLength(0); i++ )
                        for ( int j = index + 1; j < result.GetLength(1); j++ )
                            if ( this.map[i,j - 1] != null )
                            {
                                result[i,j] = this.map[i,j - 1];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                }
                else
                {
                    result = new WallEObjects[this.Rows, index + 1];

                    for ( int i = 0; i < this.Rows; i++ )
                        for ( int j = 0; j < this.Columns; j++ )
                            if ( this.map[i,j] != null )
                            {
                                result[i,j] = this.map[i,j];
                                result[i,j].ObjPosition = new Position(i,j);
                            }
                }
                this.map = result;
            }
        }

        /// <summary>
        /// Elimina la columna en el índice especificado.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveColumnAt(int index)
        {
            if ( index <= 0 && this.Columns == 1 )
                throw new InvalidOperationException("No puede eliminar la única columna que tiene.");

            if ( index >= this.Columns )
                throw new InvalidOperationException("No puede eliminar una columna que no existe.");

            WallEObjects[,] mapTemp = new WallEObjects[this.Rows, this.Columns - 1];
            if ( index <= 0 )
            {
                for ( int i = 0; i < this.Rows; i++ )
                    for ( int j = 0; j < this.Columns - 1; j++ )
                        if ( this.map[i,j + 1] != null )
                        {
                            mapTemp[i,j] = this.map[i,j + 1];
                            mapTemp[i,j].ObjPosition = new Position(i,j);
                        }
            }
            else
            {
                for ( int i = 0; i < this.Rows; i++ )
                    for ( int j = 0; j < index; j++ )
                        if ( this.map[i,j] != null )
                        {
                            mapTemp[i,j] = this.map[i,j];
                            mapTemp[i,j].ObjPosition = new Position(i,j);
                        }
                for ( int i = 0; i < this.Rows; i++ )
                    for ( int j = index + 1; j < this.Columns; j++ )
                        if ( this.map[i,j] != null )
                        {
                            mapTemp[i,j - 1] = this.map[i,j];
                            mapTemp[i,j - 1].ObjPosition = new Position(i,j - 1);
                        }
               
            }
            this.map = mapTemp;
        }
        public void RemoveRowAt(int index)
        {
            if ( index <= 0 && this.Rows == 1 )
                throw new InvalidOperationException("No puede eliminar la única fila que tiene.");
            if ( index >= this.Rows )
                throw new InvalidOperationException("No puede eliminar una fila que no existe.");

            WallEObjects[,] mapTemp = new WallEObjects[this.Rows - 1, this.Columns];
            if ( index <= 0 )
            {
                for ( int i = 0; i < this.Rows - 1; i++ )
                    for ( int j = 0; j < this.Columns - 1; j++ )
                        if ( this.map[i + 1,j] != null )
                        {
                            mapTemp[i,j] = this.map[i + 1,j];
                            mapTemp[i,j].ObjPosition = new Position(i,j);
                        }
            }
            else
            {
                for ( int i = 0; i < index; i++ )
                    for ( int j = 0; j < this.Columns; j++ )
                        if ( this.map[i,j] != null )
                        {
                            mapTemp[i,j] = this.map[i,j];
                            mapTemp[i,j].ObjPosition = new Position(i,j);
                        }

                for ( int i = index + 1; i < this.Rows; i++ )
                    for ( int j = 0; j < this.Columns; j++ )
                        if ( this.map[i,j] != null )
                        {
                            mapTemp[i -1,j] = this.map[i,j];
                            mapTemp[i -1,j].ObjPosition = new Position(i-1,j);
                        }
            }
            this.map = mapTemp;
        }
        #endregion

        #region Enumerable
        /// <summary>
        /// Devuelve un enumerable del mundo.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<WallEObjects> GetEnumerator( )
        {
            return new MapEnumerator(map);
        }
        /// <summary>
        /// Devuelve un enumerable del mundo.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );

        /// <summary>
        /// Devuelve un enumerable con los IProgrammables del mundo.
        /// </summary>
        /// <returns></returns>
        public List<IProgrammable> SelectIProgrammables( )
        {
            IEnumerable<WallEObjects> iProgrammable = this.Where((c) => c is IProgrammable);
            List<IProgrammable> result = new List<IProgrammable>( );
            foreach ( var item in iProgrammable )
                result.Add(item as IProgrammable);
            return result;
        }
        #endregion

        #endregion

        #region Static Methods
        /// <summary>
        /// Rellena un mapa con los objetos conocidos.
        /// </summary>
        /// <param name="map">Mapa creado vacío.</param>
        /// <param name="knowObjectsPosition">Objetos cuya posición es conocida.</param>
        /// <returns></returns>
        private WallEObjects[,] FillWith(WallEObjects[,] map,Tuple<WallEObjects,Position>[] knowObjectsPosition)
        {
            WallEObjects[,] result = new WallEObjects[map.GetLength(0), map.GetLength(1)];
            for ( int i = 0; i < knowObjectsPosition.Length; i++, ++this.CountObjects )
            {
                result[knowObjectsPosition[i].Item2.X,knowObjectsPosition[i].Item2.Y] = knowObjectsPosition[i].Item1;
                knowObjectsPosition[i].Item1.ObjNumber = CountObjects;
            }
            return result;
        }
        /// <summary>
        /// Determina dado un mapa y una posición si esta es válida.
        /// </summary>
        /// <param name="map">Mapa del mundo.</param>
        /// <param name="position">Posición a validar.</param>
        /// <returns></returns>
        public static bool IsValidPosition(Map map,Position position)
        {
            return position.X >= 0 && position.X < map.Rows && position.Y >= 0 && position.Y < map.Columns;
        }
        internal bool InLineSphere(Position position,int direction,out Position lastEmptyPosition)
        {
            //Mientras la posicion sea valida y lo que haya enfrente sea una bola o este vacio ...
            while ( Map.IsValidPosition(this,position.FrontPosition(direction))
                && ( this[position.FrontPosition(direction)] is Sphere
                    || this[position.FrontPosition(direction)] == null ) )
            {
                //Si la siguiente casilla esta vacia entonces si se cumple la condicion
                if ( this[position.FrontPosition(direction)] == null )
                {
                    lastEmptyPosition = position.FrontPosition(direction);
                    return true;
                }
                else if ( this[position.FrontPosition(direction)].ObjSize == (int) Sizes.Small || this[position.FrontPosition(direction)].ObjSize == (int) Sizes.Medium )
                    position = position.FrontPosition(direction);
            }
            lastEmptyPosition = new Position(-1,-1);
            return false;
        }

        #endregion

       
    }
    class MapEnumerator : IEnumerator<WallEObjects>
    {
        WallEObjects current;
        bool move;
        WallEObjects[,] map;
        Queue<WallEObjects> wObjects;

        public MapEnumerator(WallEObjects[,] map)
        {
            this.map = map;
            wObjects = SelectObjects( );
        }
        public WallEObjects Current
        {
            get
            {
                if ( !move )
                    throw new InvalidOperationException("No ha hecho MoveNext()");
                return current;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose( ) { }

        public bool MoveNext( )
        {
            if ( wObjects.Count == 0 )
                return move = false;
            current = wObjects.Dequeue( );
            return move = true;
        }

        public void Reset( )
        {
            this.current = null;
            this.move = false;
            wObjects = SelectObjects( );
        }

        private Queue<WallEObjects> SelectObjects( )
        {
            Queue<WallEObjects> tempWObjects = new Queue<WallEObjects>( );
            for ( int i = 0; i < map.GetLength(0); i++ )
                for ( int j = 0; j < map.GetLength(1); j++ )
                    if ( map[i,j] != null )
                        tempWObjects.Enqueue(map[i,j]);
            return tempWObjects;
        }
    }
}
