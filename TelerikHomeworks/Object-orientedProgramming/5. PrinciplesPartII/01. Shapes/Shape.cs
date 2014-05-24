using System;

namespace _01.Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value > 0)
                {

                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("The width must be greater than zero");
                }
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value > 0)
                {

                    this.height = value;
                }
                else
                {
                    throw new ArgumentException("The height must be greater than zero");
                }
            }
        }

        public abstract double CalculateSurface();
    }
}
