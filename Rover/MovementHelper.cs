using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public static class MovementHelper
    {
        public static Dictionary<Directions, Coordinate> _moveindirection = new Dictionary<Directions, Coordinate>
        {
            {Directions.North,new Coordinate(){ X=0,Y= 1 } },
            {Directions.South,new Coordinate(){ X=0,Y=-1 } },
            {Directions.West,new Coordinate(){ X=-1,Y=0 } },
            {Directions.East,new Coordinate(){ X=1,Y=0 } }
        };

        static Directions[] _rotatein = { Directions.East,Directions.North,Directions.West,Directions.South};
        public static LinkedList<Directions> sentence = new LinkedList<Directions>();
    }
}
