using System.Collections.Generic;

namespace RoverApplication
{
    public class Actions
    {
        private readonly List<IInstruction> _instructions = new List<IInstruction>()
        {
            new ForwardAction(),
            new RotateLeftAction(),
            new RotateRightAction()
        };

        public bool TryAction(string _input,VectorPosition _cvp, IMap m, out VectorPosition _vp)
        {
            _vp = null;
            foreach(var _instruction in _instructions)
            {
                if(_instruction.TryInstruction(_input,_cvp,m, out _vp) == true)
                    return true;
            }
            return false;
            
        }
    }
}
