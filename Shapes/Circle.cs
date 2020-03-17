using System;

namespace Shapes
{
    public class Circle : IShape
    {
        private double Radius;
        public Circle(double Radius)
        {
            if (Radius <= 0)
            {
                throw new ArgumentException("Radius must be positive", "Radius");
            }
            this.Radius = Radius;
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
