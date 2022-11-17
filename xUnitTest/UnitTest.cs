using TestTask;

namespace xUnitTest
{
    public class UnitTest
    {
        [Theory]
        [InlineData(5, 78.53981633974483)]
        [InlineData(1, 3.141592653589793)]
        public void CircleAreaEqualExpectedTheory(
            double radius, double expected)
        {
            Circle circle = new Circle(radius);

            Assert.Equal(expected, circle.Area);
        }
        [Theory]
        [InlineData(3,4,5,6)]
        [InlineData(2, 6, 7, 5.562148865321747)]
        public void TriangleAreaEqualExpectedTheory(
            double firstSide, double secondSide, double thirdSide, double expected)
        {
            Triangle triangle = new Triangle(firstSide,secondSide,thirdSide);

            Assert.Equal(expected, triangle.Area);
        }
        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 7, 9, false)]

        public void TriangleIsRightEqualExpectedTheory(
            double firstSide, double secondSide, double thirdSide, bool expected)
        {
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.Equal(expected, triangle.CheckForRight());
        }


        [Theory]
        [InlineData(0, 3, 3)]
        [InlineData(2, 5, 10)]
        public void TriangleOutOfRangeTheory(
            double firstSide, double secondSide, double thirdSide)
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CircleOutOfRange(
            double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }
    }
}