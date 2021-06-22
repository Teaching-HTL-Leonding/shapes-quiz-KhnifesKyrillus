using System;

namespace Shapes.model
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        private double Radius { get; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}