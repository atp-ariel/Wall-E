using System;
using System.Linq;
using System.IO;
using WallE.Tools;
using WallE.MATLAN;
using WallE.MATLAN.Instructions;

namespace WallE.Routine
{
    /// <summary>
    /// Maneja todo lo relacionado con el cargado y salvado de rutinas en la aplicacion.
    /// </summary>
    public static class ControllerRoutine
    {
        /// <summary>
        /// Salva un rutina en .txt
        /// </summary>
        /// <param name="routine">Rutina que se desea salvar.</param>
        /// <param name="path">Direccion donde se desea salva.</param>
        public static void SaveRoutine(Rut routine,string path)
        {
            if ( !Directory.Exists(path) )
                Directory.CreateDirectory(path);

            string pathFinal = path + "\\" + routine.Name + ".txt";

            if ( routine.Body.CountInstruction == 0 )
                throw new InvalidOperationException("No puede salvar una rutina sin instrucciones.");
            File.WriteAllLines(pathFinal,routine.ToString( ).Split('\n'));
        }
        /// <summary>
        /// Parser del .txt de donde se reciben las rutinas.
        /// </summary>
        /// <param name="path">Dirección en el disco donde se encuentra la rutina.</param>
        /// <param name="loadOk">Devuelve true si la rutina tiene un start, devuelve false si no lo tiene.</param>
        /// <returns></returns>
        public static Rut LoadRoutine(string path, out bool loadOk)
        {
            loadOk = false;
            if ( Directory.Exists(path) )
                throw new InvalidProgramException("Dirección inválida en el disco.");

            string[] stringRut = File.ReadLines(path).ToArray( );

            Rut rutResult =
                new Rut(path.Split(new char[] { '\\' },StringSplitOptions.RemoveEmptyEntries).Last( ).Split(new char[] { '.' },StringSplitOptions.RemoveEmptyEntries).First( ));

            int countInstruction = 0;
            try { countInstruction = int.Parse(stringRut[0]); }
            catch ( Exception )
            {
                throw new InvalidCastException("Formato de cantidad de instrucciones inválida.");
            }

            if ( countInstruction != stringRut.Length - 1 )
                throw new ArgumentException("Archivo de la rutina mal formado, pues tiene "+(stringRut.Length -1)+" instrucciones, cuando debía tener " + countInstruction + " instrucciones.");

            for ( int i = 1; i < stringRut.Length; i++ )
            {
                string[] tempLineRut = stringRut[i].Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                if ( tempLineRut.Length != 3 )
                    throw new ArgumentException("Formato de la línea: " + i + " inválido.");

                Position tempPosition = StringToPosition(tempLineRut[0],tempLineRut[1]);

                var tempInstruction = Instruction.ExecuteCreation(tempLineRut[2]);

                if ( tempInstruction is Start && rutResult.Body.StartPosition != null )
                    throw new InvalidOperationException("Ya existe un {start} en esta rutina.");

                rutResult.Body.AddInstructionAt(tempInstruction,tempPosition);
            }

            if ( rutResult.Body.StartPosition != null )
                loadOk = true;
            else
                throw new InvalidDataException("Esta rutina no tiene un start.");

            return rutResult;
        }
        /// <summary>
        /// Trata de parsear dos cadenas de texto a una posicion.
        /// </summary>
        /// <param name="x">Cadena asociada a la componente X de la posicion</param>
        /// <param name="y">Cadena asociada a la componente Y de la posicion</param>
        /// <returns></returns>
        private static Position StringToPosition(string x,string y)
        {
            int finalX, finalY;
            try { finalX = int.Parse(x); }
            catch ( Exception ) { throw new InvalidCastException("Coordenada X inválida."); }

            try { finalY = int.Parse(y); }
            catch ( Exception ) { throw new InvalidCastException("Coordenada Y inválida."); }

            return new Position(finalX,finalY);
        }
    }
}
