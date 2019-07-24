using Rover;
using System;
using Xunit;

namespace RoverTests
{
    public class CoordinateFixture
    {
        [Fact]
        public void can_store_coordinates()
        {
            Coordinate c = new Coordinate() { X = 1, Y = 2 };
            Assert.Equal(1, c.X);
            Assert.Equal(2, c.Y);
        }
       
    }
    
}
