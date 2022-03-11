using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using WallE.Tools;
using WallE.MATLAN;
using WallE.MATLAN.Instructions;
using WallE.World.WorldObjects;

namespace WallE.Routine
{
    /// <summary>
    /// Representa una rutina en MATLAN
    /// </summary>
    public class Rut : ICloneable, IEnumerable<Instruction>
    {
        #region Fields
        /// <summary>
        /// Representa el enumerador de la rutina.
        /// </summary>
        private IEnumerator<Instruction> enumerator;
        #endregion

        #region Properties
        /// <summary>
        /// Cuerpo de la rutina
        /// </summary>
        public MatrixInstruction Body { get; private set; }
        /// <summary>
        /// Nombre de la rutina no es obligatorio su uso es solo para distinguir entre rutinas, y para salvar la rutina, con un nombre.
        /// </summary>
        public string Name { get; set; }

        ///<summary>
        /// Registros de esta rutina.
        /// </summary>
        public Registry RegistryRoutine { get; internal set; }

        /// <summary>
        /// Entero indicando el indice de esta rutina en la lista del robot.
        /// </summary>
        public int Index { get; internal set; }
        /// <summary>
        /// Robot al que esta asociada esta rutina.
        /// </summary>
        internal IProgrammable RobotRoutine { get; set; }
        /// <summary>
        /// Determina si se esta ejecutando la rutina actualmente.
        /// </summary>
        public bool Executing { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Construye una rutina.
        /// </summary>
        public Rut( )
        {
            Simulator.Simulator.Error += StopExecutingByError;
            this.Body = new MatrixInstruction(0,0);
            this.RegistryRoutine = new Registry( );
            this.Name = string.Empty;
        }
        /// <summary>
        /// Construye una rutina dado una matriz de instrucciones.
        /// </summary>
        /// <param name="body"></param>
        public Rut(Rut.MatrixInstruction body)
        {
            this.Body = body;
            this.RegistryRoutine = new Registry( );
        }
        /// <summary>
        /// Construye una rutina con una matriz vacia, y un nombre
        /// </summary>
        /// <param name="name">Nombre de la matriz.</param>
        public Rut(string name) : this( )
        {
            this.Name = name;
        }
        #endregion

        #region Event
        /// <summary>
        /// Evento que se lanzará cada vez que se pase hacia una nueva instruccion.
        /// </summary>
        public static event EventHandler ExecuteInstruction;
        /// <summary>
        /// La posicion de la ultima instruccion que se ejecuto, por la cual se lanza el evento
        /// </summary>
        public static Position LastInstruction { get; private set; }
        /// <summary>
        /// Metodo que activa el evento ExecuteInstruction
        /// </summary>
        /// <param name="routine">Rutina que ejecuto la instruccion</param>
        /// <param name="instructionPosition">Posicion de la instruccion en la rutina.</param>
        public static void Executed(Rut routine,Position instructionPosition)
        {
            LastInstruction = instructionPosition;
            ExecuteInstruction(routine,new EventArgs( ));
            LastInstruction = null;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Ejecuta la rutina.
        /// </summary>
        public void Execute( )
        {
            //Mientras se este ejecutando la rutina, o sea no se haya llegado a un return o se haya acabado la matriz o se haya llegado a una accion fisica.
            while ( Executing )
            {

                //Ejecuta una instruccion, si con esa termina la ejecucion actual sal del ciclo.
                if ( ExecuteByInstruction( ) )
                    break;

                if ( !Executing )
                {
                    enumerator = null;
                    break;
                }
            }
        }
        /// <summary>
        /// Si ocurre un error detiene la ejecucion de esta rutina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopExecutingByError(object sender,EventArgs e)
        {
            ( (IProgrammable) sender ).ExecutingStack.Peek( ).Executing = false;
        }
        /// <summary>
        /// Ejecuta solo la siguiente instruccion de la rutina, y devuelve si con esa ejecucion el se termina o no momenteamente la ejecucion de esa rutina.
        /// </summary>
        /// <returns></returns>
        public bool ExecuteByInstruction( )
        {
            if ( enumerator == null )
                GetEnumerator( );

            //Muevo el puntero
            enumerator.MoveNext( );
            //Si no se mueve es porque se salio de los bordes de la matriz por tanto termina la ejecucion, devolviendo true.
            if ( !( (MatrixInstruction.MatrixEnumerator) enumerator ).Move )
            {
                Executing = false;
                return true;
            }

            //Activo el evento ExecuteInstruction
            Executed(this,this.Body.Flux.Position);

            //Si la instruccion es vacia es un espacio en blanco devuelve false.
            if ( enumerator.Current == null )
                return false;

            //Sino ejecutala.
            enumerator.Current.Execute(RobotRoutine);

            if ( !RobotRoutine.ExecutingStack.Peek( ).Equals(this) && RobotRoutine.ExecutingStack.Peek( ).Executing )
                return true;
            //Si no se esta ejecutando lo que esta en el tope de la pila y es esta rutina, sale devolviendo false.
            if ( !RobotRoutine.ExecutingStack.Peek( ).Executing && RobotRoutine.ExecutingStack.Peek( ).Equals(this) )
                return false;

            //Si es una accion fisica lo que se ejecuto termina devolviendo true.
            if ( enumerator.Current is IAction )
                return true;
            return false;
        }
        /// <summary>
        /// Salva la rutina en .txt
        /// </summary>
        /// <param name="pathInitial">Direccion donde se desea salvar la rutina.</param>
        public void SaveRoutine(string pathInitial)
        {
            ControllerRoutine.SaveRoutine(this,pathInitial);
        }
        /// <summary>
        /// Devuelve un string que representa la rutina.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            string s = this.Body.CountInstruction.ToString( );
            for ( int i = 0; i < this.Body.Row; i++ )
                for ( int j = 0; j < this.Body.Column; j++ )
                    if ( this.Body[new Position(i,j)] != null )
                        s += "\n" + new Position(i,j).ToString( ) + " " + this.Body[new Position(i,j)].ToString( );
            return s;
        }
        /// <summary>
        /// Dos rutinas son iguales si tienen el mismo cuerpo de instrucciones.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( !( obj is Rut ) )
                return false;
            return this.Body.Equals(( (Rut) obj ).Body);
        }
        public override int GetHashCode( )
        {
            return (int) Math.Sqrt(( this.Body.GetHashCode( ) + this.RegistryRoutine.GetHashCode( ) ));
        }
        /// <summary>
        /// Devuelve otra matriz con las mismas instrucciones y el mismo indice.
        /// </summary>
        /// <returns></returns>
        public object Clone( )
        {
            var rut = new Rut((MatrixInstruction) this.Body.Clone( ));
            rut.Index = this.Index;
            return rut;
        }

        /// <summary>
        /// Devuelve un enumerator de instruccione. Modifica el campo enumerator de la clase.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Instruction> GetEnumerator( )
        {
            return enumerator = this.Body.GetEnumerator( );
        }
        IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );
        /// <summary>
        /// Devuelve un enumerable de instrucciones y su posicion en la matriz.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tuple<Instruction,Position>> GetAllInstructionAndPositions( )
        {
            for ( int i = 0; i < this.Body.Row; i++ )
                for ( int j = 0; j < this.Body.Column; j++ )
                    if ( Body[new Position(i,j)] != null )
                        yield return Tuple.Create(Body[new Position(i,j)],new Position(i,j));
        }
        /// <summary>
        /// Devuelve todas las instrucciones de la matriz aunque no nunca sean accesibles por el flujo, o sea, devuelve todo lo que esta en la matriz.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Instruction> GetAllInstruction( )
        {
            for ( int i = 0; i < this.Body.Row; i++ )
                for ( int j = 0; j < this.Body.Column; j++ )
                    if ( Body[new Position(i,j)] != null )
                        yield return Body[new Position(i,j)];
        }

        /// <summary>
        /// Valida una matriz, o sea, verifica que tenga un {start}.
        /// </summary>
        /// <param name="routine"></param>
        /// <returns></returns>
        public static bool ValidateRut(Rut routine)
        {
            return routine.Body.StartPosition != null;
        }
        #endregion 


        /// <summary>
        /// Representa un registro de la rutina.
        /// </summary>
        public class Registry : ICloneable
        {
            #region Field
            /// <summary>
            /// Registro.
            /// </summary>
            private Dictionary<char,int> registry;
            #endregion

            #region Properties
            /// <summary>
            /// Indexador del registro
            /// </summary>
            /// <param name="letter"></param>
            /// <returns></returns>
            public int this[char letter]
            {
                get
                {
                    //Si no se ha guardado nada con esa llave entonces, devuelve 0.
                    if ( !registry.ContainsKey(letter) )
                        return 0;
                    return registry[letter];
                }
            }
            #endregion

            #region Constructor
            /// <summary>
            /// Construye un registro con capacidad para 26 letras (no Ñ)
            /// </summary>
            public Registry( )
            {
                this.registry = new Dictionary<char,int>(26);
            }
            #endregion

            #region Methods
            /// <summary>
            /// Añade un valor al registro.
            /// </summary>
            /// <param name="letter">Índice donde se desea añadir.</param>
            /// <param name="value">Valor a añadir.</param>
            internal void AddValueAt(char letter,int value)
            {

                if ( !Char.IsLetter(letter) )
                    throw new ArgumentException("No es una letra: ",letter.ToString( ));
                this.registry[letter.ToString().ToUpper().ToCharArray()[0]] = value;
            }

            /// <summary>
            /// Dos registros son iguales si los diccionarios asociados son iguales.
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                if ( !( obj is Registry ) )
                    return false;
                return this.registry.Equals(( (Registry) obj ).registry);
            }
            public override int GetHashCode( )
            {
                return 2 * this.registry.GetHashCode( );
            }
            /// <summary>
            /// Devuelve otro registro pero con los mismo valores, y llaves.
            /// </summary>
            /// <returns></returns>
            public object Clone( )
            {
                Registry registryClone = new Registry( );
                foreach ( var item in this.registry )
                    registryClone.AddValueAt(item.Key,item.Value);
                return registryClone;
            }
            #endregion
        }
        public class MatrixInstruction : IEnumerable<Instruction>, ICloneable
        {
            #region Properties

            /// <summary>
            /// Matriz de instrucciones.
            /// </summary>
            internal Instruction[,] Matrix { get; private set; }

            /// <summary>
            /// Cantidad de filas de la matriz.
            /// </summary>
            public int Row => this.Matrix.GetLength(0);

            /// <summary>
            /// Cantidad de columnas de la matriz.
            /// </summary>
            public int Column => this.Matrix.GetLength(1);

            /// <summary>
            /// Cantidad de instrucciones en la matriz.
            /// </summary>
            internal int CountInstruction { get; private set; }

            /// <summary>
            /// Posición de la instruccion Start en la matriz.
            /// </summary>
            internal Position StartPosition { get; private set; }
            /// <summary>
            /// Cursor de recorrido en la matriz.
            /// </summary>
            internal Pointer Flux { get; private set; }

            #endregion

            #region Constructor
            /// <summary>
            /// Construye una matriz de instrucciones.
            /// </summary>
            /// <param name="row">Cantidad de filas.</param>
            /// <param name="column">Cantidad de columnas.</param>
            public MatrixInstruction(int row,int column)
            {
                if ( row < 0 || column < 0 )
                    throw new ArgumentException("No puede construir una matriz de instrucciones una cantidad de filas o columnas menor a 0." );

                this.Matrix = new Instruction[row, column];
                this.StartPosition = null;
            }
            #endregion

            #region Methods

            #region Instruction Methods
            /// <summary>
            /// Añade la instruccion Start en una posición determinada.
            /// </summary>
            /// <param name="start"></param>
            /// <param name="indexRow"></param>
            /// <param name="indexColumn"></param>
            private void AddStartAt(int indexRow,int indexColumn)
            {
                IsInside(indexRow,indexColumn);
                if ( this.StartPosition == null )
                {
                    this[indexRow,indexColumn] = new Start( );
                    StartPosition = new Position(indexRow,indexColumn);
                    this.CountInstruction++;
                }
                else
                    throw new InvalidOperationException("Existe un start.");
            }

            /// <summary>
            /// Añade una instrucción a la matriz en una posición determinada.
            /// </summary>
            /// <param name="instruction">Instrucción a añadir.</param>
            /// <param name="position">Posición en la que se desea añadir la instrucción.</param>
            public void AddInstructionAt(Instruction instruction,Position position) => AddInstructionAt(instruction,position.X,position.Y);
            /// <summary>
            /// Añade la instruccion Start en una posición determinada.
            /// </summary>
            /// <param name="start"></param>
            /// <param name="indexRow"></param>
            /// <param name="indexColumn"></param>
            private void AddInstructionAt(Instruction instruction,int indexRow,int indexColumn)
            {
               
                //Si la posicion no existe entonces aumento mi matriz y añado la posicion.
                while ( indexRow >= this.Row )
                    AddLastRow( );
                while ( indexColumn >= this.Column )
                    AddLastColumn( );

                if ( this[indexRow,indexColumn] != null )
                    return;

                if ( instruction is Start )
                {
                    AddStartAt(indexRow,indexColumn);
                    return;
                }

                this[indexRow,indexColumn] = instruction;
                this.CountInstruction++;
            }

            /// <summary>
            /// Remueve la instrucción en la posición.
            /// </summary>
            /// <param name="position"></param>
            public void RemoveInstructionAt(Position position) => RemoveInstructionAt(position.X,position.Y);
            /// <summary>
            /// Remueve la instrucción en la posición.
            /// </summary>
            /// <param name="indexRow"></param>
            /// <param name="indexColumn"></param>
            private void RemoveInstructionAt(int indexRow,int indexColumn)
            {
                IsInside(indexRow,indexColumn);
                if ( this[indexRow,indexColumn] is Start )
                    StartPosition = null;
                this[indexRow,indexColumn] = null;
                this.CountInstruction--;
            }
            #endregion

            #region Structural Methods
            ///<summary>
            /// Añade una fila al final de la matriz.
            /// </summary>
            private void AddLastRow( )
            {
                AddRowAt(this.Row);
            }
            /// <summary>
            /// Añade una columna al final de la matriz.
            /// </summary>
            private void AddLastColumn( )
            {
                AddColumnAt(this.Column);
            }

            /// <summary>
            /// Añade una fila al inicio de la matriz.
            /// </summary>
            private void AddFirstRow( )
            {
                Instruction[,] result = new Instruction[this.Row + 1, this.Column];

                for ( int i = 1; i < result.GetLength(0); i++ )
                    for ( int j = 0; j < result.GetLength(1); j++ )
                        result[i,j] = this[i - 1,j];
                this.Matrix = result;
            }
            /// <summary>
            /// Añade una columna al inicio de la matriz.
            /// </summary>
            private void AddFirstColumn( )
            {
                Instruction[,] result = new Instruction[this.Row, this.Column + 1];

                for ( int i = 0; i < result.GetLength(0); i++ )
                    for ( int j = 1; j < result.GetLength(1); j++ )
                        result[i,j] = this[i,j - 1];

                this.Matrix = result;
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
                    Instruction[,] result;
                    if ( index < this.Row )
                    {
                        result = new Instruction[this.Row + 1, this.Column];

                        for ( int i = 0; i < index; i++ )
                            for ( int j = 0; j < result.GetLength(1); j++ )
                                result[i,j] = this[i,j];
                        for ( int i = index + 1; i < result.GetLength(0); i++ )
                            for ( int j = 0; j < result.GetLength(1); j++ )
                                result[i,j] = this[i - 1,j];
                    }
                    else
                    {
                        result = new Instruction[index + 1, this.Column];

                        for ( int i = 0; i < this.Row; i++ )
                            for ( int j = 0; j < this.Column; j++ )
                                result[i,j] = this[i,j];
                    }
                    this.Matrix = result;
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
                    Instruction[,] result;
                    if ( index < this.Column )
                    {
                        result = new Instruction[this.Row, this.Column + 1];

                        for ( int i = 0; i < result.GetLength(0); i++ )
                            for ( int j = 0; j < index; j++ )
                                result[i,j] = this[i,j];
                        for ( int i = 0; i < result.GetLength(0); i++ )
                            for ( int j = index + 1; j < result.GetLength(1); j++ )
                                result[i,j] = this[i,j - 1];
                    }
                    else
                    {
                        result = new Instruction[this.Row, index + 1];

                        for ( int i = 0; i < this.Row; i++ )
                            for ( int j = 0; j < this.Column; j++ )
                                result[i,j] = this[i,j];
                    }
                    this.Matrix = result;
                }
            }

            /// <summary>
            /// Indexador de la matriz de instrucciones.
            /// </summary>
            /// <param name="position"></param>
            /// <returns></returns>
            public Instruction this[Position position]
            {
                get
                {
                    if ( position == null || this[position.X,position.Y] == null )
                        return null;
                    return this[position.X,position.Y];
                }
            }
            /// <summary>
            /// Indexador de la matriz de instrucciones
            /// </summary>
            /// <param name="indexRow"></param>
            /// <param name="indexColumn"></param>
            /// <returns></returns>
            private Instruction this[int indexRow, int indexColumn]
            {
                get
                {
                    IsInside(indexRow,indexColumn);
                    if ( this.Matrix[indexRow,indexColumn] == null )
                        return null;
                    return this.Matrix[indexRow,indexColumn];
                }
                set
                {
                    if ( !( value is Instruction ) && value != null )
                        throw new ArgumentException("No es una instruccion: ",value.ToString( ));
                    if ( value is Start && StartPosition != null )
                        throw new InvalidOperationException("Ya existe un Start en: " + StartPosition.ToString( ) + ".");
                    IsInside(indexRow,indexColumn);
                    this.Matrix[indexRow,indexColumn] = value;
                }
            }
            #endregion

            #region Enumerable

            /// <summary>
            /// Devuelve un enumerator de instrucciones de la matriz.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<Instruction> GetEnumerator( )
            {
                return new MatrixEnumerator(this);
            }
            IEnumerator IEnumerable.GetEnumerator( ) => GetEnumerator( );

            #endregion

            #region Auxiliar Methods
            /// <summary>
            /// Lanza exception si los parametros no son validos.
            /// </summary>
            /// <param name="indexRow"></param>
            /// <param name="indexColumn"></param>
            public void IsInside(int indexRow,int indexColumn)
            {
                if ( indexRow < 0 || indexRow > this.Row )
                    throw new ArgumentOutOfRangeException("Fila incorrecta.");
                if ( indexColumn < 0 || indexColumn > this.Column )
                    throw new ArgumentOutOfRangeException("Columna incorrecta.");
            }
            /// <summary>
            /// Devuelve una nueva matriz de instrucciones con estas mismas instrucciones.
            /// </summary>
            /// <returns></returns>
            public object Clone( )
            {
                MatrixInstruction matrixClone = new MatrixInstruction(this.Row,this.Column);
                for ( int i = 0; i < this.Row; i++ )
                    for ( int j = 0; j < this.Column; j++ )
                        if ( this.Matrix[i,j] != null )
                            matrixClone.AddInstructionAt((Instruction) this[i,j].Clone( ),new Position(i,j));
                return matrixClone;
            }
            public override bool Equals(object obj)
            {
                if ( !( obj is MatrixInstruction ) )
                    return false;

                MatrixInstruction temp = obj as MatrixInstruction;

                if ( this.Row != temp.Row || this.Column != temp.Column )
                    return false;

                for ( int i = 0; i < temp.Row; i++ )
                    for ( int j = 0; j < temp.Column; j++ )
                        if ( this[i,j] == null && temp[i,j] == null )
                            continue;
                        else if ( !this[i,j].Equals(temp[i,j]) )
                            return false;

                return true;
            }
            public override int GetHashCode( )
            {
                int hash = 0;
                foreach ( var item in this )
                    hash += ( ( item.GetHashCode( ) - 7 ) / 3 );
                return hash;
            }
            #endregion

            #region Manage Pointer

            /// <summary>
            /// Pone el puntero de la matriz en la posicion del {start}
            /// </summary>
            internal void FluxReset( )
            {
                this.Flux = new Pointer(StartPosition,2);
            }
            #endregion

            #endregion

            /// <summary>
            /// Puntero  de recorrido de la matriz.
            /// </summary>
            public class Pointer
            {
                #region Fields
                /// <summary>
                /// Posicion del puntero en la matriz.
                /// </summary>
                private Position position;
                #endregion

                #region Properties
                /// <summary>
                /// Posicion del puntero en la matriz.
                /// </summary>
                public Position Position => this.position;
                /// <summary>
                /// Direccion del puntero en la matriz.
                /// </summary>
                internal byte Direction { get; set; }
                #endregion

                #region Constructor
                public Pointer(Position position,byte direction)
                {
                    this.position = position;
                    this.Direction = direction;
                }
                #endregion

                #region Methods
                /// <summary>
                /// Mueve el puntero hacia la posicion del frente.
                /// </summary>
                /// <param name="matrix"></param>
                public void Advance(MatrixInstruction matrix)
                {
                    Position frontPosition = position.FrontPosition(this.Direction);
                    if ( IsInside(matrix) )
                        this.position = frontPosition;
                    else
                        this.position = new Position(-1,-1);
                }
                /// <summary>
                /// Valida una posicion en la matriz.
                /// </summary>
                /// <param name="position">Posicion a validar.</param>
                /// <param name="matrix">Matriz donde se desea validar la posicion.</param>
                /// <returns></returns>
                public bool IsInside(MatrixInstruction matrix)
                {
                    return this.position.X >= 0 && this.position.X < matrix.Row && this.position.Y >= 0 && this.position.Y < matrix.Column;
                }
                #endregion
            }
            internal class MatrixEnumerator : IEnumerator<Instruction>
            {
                #region Fields
                MatrixInstruction matrix;
                Instruction current;
                internal bool Move
                {
                    get; private set;
                }
                #endregion

                #region Constructor
                public MatrixEnumerator(MatrixInstruction matrix)
                {
                    this.matrix = matrix;
                    this.Move = false;
                }
                #endregion

                #region Properties
                public Instruction Current
                {
                    get
                    {
                        if ( !Move )
                            throw new InvalidOperationException("Tiene que hacer .MoveNext()");
                        return current;
                    }
                }
                object IEnumerator.Current => Current;
                #endregion

                #region Methods
                public void Dispose( )
                {

                }

                public bool MoveNext( )
                {
                    if ( matrix.Flux == null )
                    {
                        matrix.FluxReset( );
                        this.current = matrix[matrix.Flux.Position];
                        return Move = true;
                    }
                    else
                    {
                        matrix.Flux.Advance(matrix);
                        if ( matrix.Flux.IsInside(matrix) )
                        {
                            this.current = matrix[matrix.Flux.Position];
                            return Move = true;
                        }
                    }
                    return Move = false;
                }

                public void Reset( )
                {
                    current = null;
                    Move = false;
                    matrix.Flux = null;
                }
                #endregion
            }
        }
    }
}

