using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class Actions
    {
        private readonly List<IInstruction> _instructions = new List<IInstruction>()
        {
            new ForwardAction(),
            new RotateLeftAction(),
            new RotateRightAction()
        };

        public bool TryAction(string _input,VectorPosition _cvp,out VectorPosition _vp)
        {
            _vp = null;
            foreach(var _instruction in _instructions)
            {
                if(_instruction.TryInstruction(_input,_cvp,out _vp) == true)
                    return true;
            }
            return false;
            
        }
    }
}
