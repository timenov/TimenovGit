﻿using System;

namespace _01.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
