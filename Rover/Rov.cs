using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApplication
{
    public class Rov
    {
        public Rov(string x, string y , Directions d,IMap _map)
        {
            _vectorposition._coordinate.X = int.Parse(x);
            _vectorposition._coordinate.Y = int.Parse(y);
            _vectorposition._direction = d;
             map = _map;
        }

        public VectorPosition _vectorposition= new VectorPosition();
        public IMap map;
        public Actions _actions= new Actions();

        public void PassInstruction(string _instr)
        {
            if (_actions.TryAction(_instr, _vectorposition,map, out VectorPosition _resultvectorposition) == true)
                _vectorposition = _resultvectorposition;
            return;
        }

        public void DisplayVectorPosition()
        {
            Console.WriteLine($"Coordinates are {_vectorposition._coordinate.X} , {_vectorposition._coordinate.Y}");
            Console.WriteLine($"Direction is{_vectorposition._direction}");
        }

        public int DisplayVectorPositionX()
        {
            return _vectorposition._coordinate.X;  
        }

        public int DisplayVectorPositionY()
        {
            return _vectorposition._coordinate.Y;
        }

        public Enum DisplayVectorPositionD()
        {
            return _vectorposition._direction;
        }

    }
}
