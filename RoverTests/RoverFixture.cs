using RoverApplication;
using Xunit;

namespace RoverTests
{
    public class RoverFixture
    {
        [Fact]
        public void test_rover_actions()
        {
            Mars m = new Mars();
            Rov r = new Rov("1", "2", Directions.North,m);

            Assert.Equal(1,r.DisplayVectorPositionX());
            Assert.Equal(2, r.DisplayVectorPositionY());
            Assert.Equal(Directions.North, r.DisplayVectorPositionD());
          
            r.PassInstruction("F");
            Assert.Equal(1, r.DisplayVectorPositionX());
            Assert.Equal(3, r.DisplayVectorPositionY());
            Assert.Equal(Directions.North, r.DisplayVectorPositionD());

            r.PassInstruction("L");
            Assert.Equal(1, r.DisplayVectorPositionX());
            Assert.Equal(3, r.DisplayVectorPositionY());
            Assert.Equal(Directions.NorthWest, r.DisplayVectorPositionD());

            r.PassInstruction("F");
            Assert.Equal(0, r.DisplayVectorPositionX());
            Assert.Equal(4, r.DisplayVectorPositionY());
            Assert.Equal(Directions.NorthWest, r.DisplayVectorPositionD());

            r.PassInstruction("R");
            Assert.Equal(0, r.DisplayVectorPositionX());
            Assert.Equal(4, r.DisplayVectorPositionY());
            Assert.Equal(Directions.North, r.DisplayVectorPositionD());

            r.PassInstruction("F");
            Assert.Equal(0, r.DisplayVectorPositionX());
            Assert.Equal(5, r.DisplayVectorPositionY());
            Assert.Equal(Directions.North, r.DisplayVectorPositionD());


        }
    }
}
