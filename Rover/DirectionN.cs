using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class DirectionN : IDirection
    {
        public Coordinate _north = new Coordinate() {X=0,Y=1 };
    }
}
