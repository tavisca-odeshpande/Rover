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

        public static Dictionary<int,Directions> _rotateindirection = new Dictionary<int,Directions>
        {
            {0,Directions.North},
            {1,Directions.East},
            {2,Directions.South},
            {3,Directions.West}
        };

        public static Directions Rotate(Directions d, int param)
        {
            int res = ((int)d + param) % 4;
            Directions result = _rotateindirection[res];
            return result;
         }


    }
}
