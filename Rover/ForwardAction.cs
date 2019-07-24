namespace Rover
{
    class ForwardAction : IInstruction
    {
        public bool TryInstruction(string _input, VectorPosition _cvp, out VectorPosition _vp)
        {
            _vp = _cvp;
            if (_input == "F")
            {
                _vp._coordinate = _vp._coordinate.Add(MovementHelper._moveindirection[_vp._direction]);
                return true;
            }
            else   
                return false;
        }
    }
}
