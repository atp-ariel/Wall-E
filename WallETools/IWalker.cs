using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallETools
{
    /// <summary>
    /// Representa el comportamiento de todo objeto que se mueva por si solo. Aqui se definiran las reglas de su movimiento.
    /// </summary>
    public interface IWalker
    {
        int Time{ get; set; }
        void Back( );
        void Advance( );
    }
}
