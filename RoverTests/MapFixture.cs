using RoverApplication;
using Xunit;

namespace RoverTests
{
    public class MapFixture
    {
        [Fact]
        public void test_map_size()
        {
            Mars map = new Mars();
            Assert.Equal(5, map.size.X);
            Assert.Equal(5, map.size.Y);
        }
    }
}
