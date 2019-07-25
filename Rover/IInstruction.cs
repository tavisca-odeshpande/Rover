using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApplication
{
    public interface IInstruction
    {
        bool TryInstruction(string _input, VectorPosition _cvp,IMap m, out VectorPosition _vposition);
    }
}
