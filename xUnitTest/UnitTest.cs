using TestTask;

namespace xUnitTest
{
    public class UnitTest
    {
        [Theory]
        [InlineData(5, 78.53981633974483)]
        [InlineData(0, 123)]
        [InlineData(1, 3.141592653589793)]
        public void CircleAreaEqualExpectedTheory(
            double radius, double expected)
        {
            Circle circle = new Circle(radius);

            Assert.Equal(expected, circle.Area);
        }
        [Theory]
        [InlineData(3,4,5,6)]
        [InlineData(0, 1, 4, 5)]
        [InlineData(5, 1, 2, 4)]
        public void TriangleAreaEqualExpectedTheory(
            double firstSide, double secondSide, double thirdSide, double expected)
        {
            Triangle triangle = new Triangle(firstSide,secondSide,thirdSide);

            Assert.Equal(expected, triangle.Area);
        }
        [Theory]
        [InlineData(3,4,5, true)]
        [InlineData(0, 1, 4, true)]
        [InlineData(1, 4, 8, false)]

        public void TriangleIsRightEqualExpectedTheory(
            double firstSide, double secondSide, double thirdSide, bool expected)
        {
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.Equal(expected, triangle.CheckForRight());
        }


        [Fact]
        public void TriangleOutOfRange()
        {
            double firstSide = 0;
            double secondSide = 0;
            double thirdSide = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }
    }
}