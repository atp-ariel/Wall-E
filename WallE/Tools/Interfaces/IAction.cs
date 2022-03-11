using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WallE.Tools
{
    public interface IAction
    {
        void Proceed(IProgrammable robot);
    }
}
