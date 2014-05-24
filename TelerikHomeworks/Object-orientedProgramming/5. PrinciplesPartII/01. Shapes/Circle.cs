using System;

namespace _01.Shapes
{
    class Circle : Shape
    {
        public Circle(double height)
        {
            this.Width = height;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.Height * this.Height;
        }
    }
}
