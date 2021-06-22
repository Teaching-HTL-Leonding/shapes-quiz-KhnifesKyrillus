namespace Shapes.model
{
    public class Triangle : IShape
    {
        public Triangle(double height, double baseSide)
        {
            Height = height;
            BaseSide = baseSide;
        }

        private double Height { get; }
        private double BaseSide { get; }

        public double GetArea()
        {
            return (BaseSide * Height) / 2;
        }
    }
}