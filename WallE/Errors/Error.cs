using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using System.Media;

namespace WallE.Errors
{
    /// <summary>
    /// Esta clase representa un error de cualquier tipo que puede ocurrir durante la simulación.
    /// </summary>
    public class Error
    {
        #region Properties
        /// <summary>
        /// Mensaje del error explicando las razones y consecuencias del error.
        /// </summary>
        public string Message { get; private set; }
        /// <summary>
        /// Error actual en la simulación.
        /// </summary>
        public static Error CurrentError { get; private set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor de error.
        /// </summary>
        /// <param name="message">Mensaje del error.</param>
        public Error(string message)
        {
            this.Message = message;
        }
        #endregion

        #region Methods
        /// <summary>
        /// La cadena de texto que representa un error determinado.
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            return "ERROR!!!! " + this.Message;
        }
        /// <summary>
        /// Método que reporta el error y levanta el evento SystemError
        /// </summary>
        /// <param name="sender">Objeto IProgrammble que envia el error.</param>
        /// <param name="error">Error a reportar.</param>
        public static void ReportError(IProgrammable sender,Error error)
        {
            CurrentError = error;
            SystemSounds.Exclamation.Play( );
            SystemError(sender,new EventArgs( ));
        }

        #endregion

        #region Event
        /// <summary>
        /// Evento que se lanza cuando se detecta un error de ejecución de las rutinas, como pila de ejecución llena, la pila del robot esta sobrecargada.
        /// </summary>
        public static event EventHandler SystemError;
        #endregion

    }
}
