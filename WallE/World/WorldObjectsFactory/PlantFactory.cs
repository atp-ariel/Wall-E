using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.World.WorldObjects;

namespace WallE.World.WorldObjectsFactory
{
    class PlantFactory : WallEObjectsFactory
    {
        public override WallEObjects Create( ) => new Plant( );
    }
}
