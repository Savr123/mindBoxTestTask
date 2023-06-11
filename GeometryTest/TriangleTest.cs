﻿using NUnit.Framework;
using testTaskMindbox.Figures.TwoDimensionalPlane;

namespace GeometryTest
{
    public class TriangleTest
    {
        [TestCase(-1, 1, 1)]
        [TestCase(1,-1,1)]
        [TestCase(1,1,-1)]
        [TestCase(0,0,0)]
        public void InitTriangleWithErrorTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void GetSquareTest()
        {
            double a = 3d, b = 4d, c = 5d;
            double result = 6d;
            var triangle = new Triangle(a, b, c);

            var square = triangle.GetSquare();
            Assert.NotNull(square);
            Assert.AreEqual(result, square);
        }

        [Test]
        public void InitNotTriangleTest()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(1,2,3));
        }
    }
}
