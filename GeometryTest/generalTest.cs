using NUnit.Framework;
using testTaskMindbox.Figures;
using testTaskMindbox.Figures.TwoDimensionalPlane;

namespace GeometryTest
{
    public class generalTest
    {
        [Test]
        public void CalculateSquareTest()
        {
            CalculateSquare(new Circle(1));
        }
        public double CalculateSquare(IFiguire figure)
        {
            return figure.GetSquare();
        }
    }
}
