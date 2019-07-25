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
            _vp = _cvp;
            if (_input == "L")
            {
                _vp._direction = MovementHelper.Rotate(_cvp._direction, 3);
            }
            _vp = _cvp;
            return false;
        }
    }
}
