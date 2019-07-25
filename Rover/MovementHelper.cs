using System.Collections.Generic;

namespace RoverApplication
{
    public static class MovementHelper
    {
        public static Dictionary<Directions, Coordinate> _moveindirection = new Dictionary<Directions, Coordinate>
        {
            {Directions.North,new Coordinate(){ X=0,Y= 1 } },
            {Directions.NorthEast,new Coordinate(){ X=1,Y= 1 } },
            {Directions.East,new Coordinate(){ X=1,Y= 0 } },
            {Directions.SouthEast,new Coordinate(){ X=1,Y=-1 } },
            {Directions.South,new Coordinate(){ X=0,Y=-1 } },
            {Directions.SouthWest,new Coordinate(){ X=-1,Y=-1 } },
            {Directions.West,new Coordinate(){ X=-1,Y=0 } },
            {Directions.NorthWest,new Coordinate(){ X=-1,Y=1 } }
        };

        public static Dictionary<int,Directions> _rotateindirection = new Dictionary<int,Directions>
        {
            {0,Directions.North},
            {1,Directions.NorthEast},
            {2,Directions.East},
            {3,Directions.SouthEast},
            {4,Directions.South},
            {5,Directions.SouthWest},
            {6,Directions.West},
            {7,Directions.NorthWest}
        };

        public static Directions Rotate(Directions d, int param)
        {
            int res = ((int)d + param) % 8;
            Directions result = _rotateindirection[res];
            return result;
         }



    }
}
