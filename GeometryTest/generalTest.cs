using NUnit.Framework;
using testTaskMindbox.Figures;
using testTaskMindbox.Figures.TwoDimensionalPlane;

namespace GeometryTest
{
    public class generalTest
    {
        [TestCase(new Circle(12))]
        public double CalculateSquare(IFiguire figure)
        {
            return figure.GetSquare();
        }
    }
}
