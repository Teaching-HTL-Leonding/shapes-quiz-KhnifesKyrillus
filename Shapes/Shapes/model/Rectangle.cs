namespace Shapes.model
{
    public class Rectangle : IShape
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        private double Length { get; }
        private double Width { get; }

        public double GetArea()
        {
            return Length * Width;
        }
    }
}