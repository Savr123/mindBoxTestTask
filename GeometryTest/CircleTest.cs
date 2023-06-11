using testTaskMindbox.Figures;
using NUnit.Framework;
using testTaskMindbox.Figures.TwoDimensionalPlane;

namespace GeometryTest
{
    public class CircleTest
    {
        [Test]
        public void ZeroRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0d));
        }

        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-12d));
        }

        [Test]
        public void GetSquareTest()
        {
            var radius = 12;
            var circle = new Circle(radius);
            var expectedSquare = Math.Pow(radius, 2) * Math.PI;

            var square = circle.GetSquare();
            Assert.AreEqual(expectedSquare, square);
        }
    }
}