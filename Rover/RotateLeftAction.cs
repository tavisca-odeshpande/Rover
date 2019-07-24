using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class RotateLeftAction : IInstruction
    {
        
        public bool TryInstruction(string _input, VectorPosition _cvp, out VectorPosition _vp)
        {
            _vp = null;
            if (_input == "L")
            {
                _vp = _cvp;
                return true;
            }
            _vp = _cvp;
            return false;
        }
    }
}
