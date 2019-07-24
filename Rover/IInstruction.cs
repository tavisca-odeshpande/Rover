using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public interface IInstruction
    {
        bool TryInstruction(string _input, VectorPosition _cvp, out VectorPosition _vposition);
    }
}
