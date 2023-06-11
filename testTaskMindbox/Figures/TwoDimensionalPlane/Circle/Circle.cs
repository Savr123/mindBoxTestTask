using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTaskMindbox.Figures.TwoDimensionalPlane
{
    public class Circle : ICircle
    {
        public double radius { get; set; }
        public double diametr { get { return radius * 2; } }
        public double circumference { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Неверно указан радиус");
            this.radius = radius;
        }

        public double GetSquare()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
        public virtual bool Equal(Circle other)
        {
            if (other == null) throw new ArgumentException("Input parametr cannot be null");
            if (other is not Circle circle) return false;
            if (other.radius == radius) return true;
            return false;
        }
    }
}
