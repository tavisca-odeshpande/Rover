using Rover;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RoverTests
{
    public class RoverFixture
    {
        [Fact]
        public void test_rover_actions()
        {
            Rov r = new Rov("1", "2", Directions.North);
            r.DisplayVectorPosition();
            r.PassInstruction("L");
            r.DisplayVectorPosition();
        }
    }
}
