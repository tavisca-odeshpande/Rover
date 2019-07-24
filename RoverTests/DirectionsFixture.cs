using Xunit;
using Rover;

namespace RoverTests
{
    public class DirectionsFixture
    {
        [Fact]
        public void validate_directionN()
        {
            DirectionN d = new DirectionN();
            Assert.Equal(0, d._direction.X);
            Assert.Equal(1, d._direction.Y);
        }

        [Fact]
        public void validate_directionE()
        {
            DirectionE d = new DirectionE();
            Assert.Equal(1, d._direction.X);
            Assert.Equal(0, d._direction.Y);
        }

        [Fact]
        public void validate_directionS()
        {
            DirectionS d = new DirectionS();
            Assert.Equal(0, d._direction.X);
            Assert.Equal(-1, d._direction.Y);
        }

        [Fact]
        public void validate_directionW()
        {
            DirectionW d = new DirectionW();
            Assert.Equal(-1, d._direction.X);
            Assert.Equal(0, d._direction.Y);
        }
    }
}
