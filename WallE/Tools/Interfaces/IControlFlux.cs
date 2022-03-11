using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Routine;

namespace WallE.Tools
{
    public interface IControlFlux
    {
        void Control(Rut routine);
    }
}
