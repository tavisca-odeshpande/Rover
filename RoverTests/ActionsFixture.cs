using RoverApplication;
using Xunit;

namespace RoverTests
{
    public class ActionsFixture
    {
        [Fact]
        public void check_()
        {
            Directions _direction = Directions.North;
            Coordinate _coordinate = new Coordinate() { X = 2, Y = 2 };
            _coordinate = _coordinate.Add(MovementHelper._moveindirection[_direction]);
            Assert.Equal(2, _coordinate.X);
            Assert.Equal(3, _coordinate.Y);
        }
    }
}
