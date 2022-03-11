using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WallE.World.WorldObjects;
using System.Threading.Tasks;

namespace WallE.Tools
{
    public interface ILoader
    {
        WallEObjects ObjectInside { get; set; }
        void Drop( );
    }
}
