using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class RotateRightAction : IInstruction
    {
        public bool TryInstruction(string _input, VectorPosition _cvp, out VectorPosition _vp)
        {
            _vp = _cvp;
            if (_input == "R")
            {
                _vp._direction = MovementHelper.Rotate(_cvp._direction, 1);
            }
            _vp = _cvp;
            return false;
        }
    }
}
