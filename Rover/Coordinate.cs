
namespace RoverApplication
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate Add(Coordinate _newcoordinate)
        {
            Coordinate res = new Coordinate();
            res.X = this.X + _newcoordinate.X;
            res.Y = this.Y + _newcoordinate.Y;

            return res;
        }
    }

}
