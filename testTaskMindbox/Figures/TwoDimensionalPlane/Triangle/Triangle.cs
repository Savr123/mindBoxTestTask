using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTaskMindbox.Figures.TwoDimensionalPlane
{
    public class Triangle : ITriangle
    {
        public Triangle(double A, double B, double C)
        {
            if (A + B <= C || B + C <= A || A + C <= B || (A + B + C == 0))
                throw new ArgumentException("Треугольник с такими сторонами не может существовать");
            this.sideA = A;
            this.sideB = B;
            this.sideC = C;
        }
        public double GetSquare()
        {
            double halfPerimetr = (sideA + sideB + sideC) / 2d;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - sideA) * (halfPerimetr - sideB) * (halfPerimetr - sideC));
        }
        public bool ifRightTriangle ()
        {
            var hypotenuse = Math.Max(Math.Max(sideA, sideB), sideC);
            if (hypotenuse == sideA)
                return Math.Sqrt(Math.Pow(sideC, 2) + Math.Pow(sideB, 2)) == sideA;
            if (hypotenuse == sideB)
                return Math.Sqrt(Math.Pow(sideC, 2) + Math.Pow(sideA, 2)) == sideB;
            return Math.Sqrt(Math.Pow(sideB, 2) + Math.Pow(sideA, 2)) == sideC;
        }

    }
}
