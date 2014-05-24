using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class MainClass
    {
        static void Main()
        {
            Shape[] shapes = new Shape[] { new Triangle(2.3, 4.5),
                                            new Rectangle(1.23, 2.34),
                                            new Circle(4.5) };

            foreach (var shape in shapes)
            {
                Console.WriteLine("surface of {0} is {1}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
