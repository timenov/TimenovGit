using System;
using System.Text;

class QuadraticEquation
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode; // displaying index for square
        Console.WriteLine("Quadratic equation is ax{0} + bx + c = 0.", (char)0x00B2);
        // insert coef.
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());

        // calculate discriminant
        float disc = b * b - 4 * a * c;
        
        float x1 = 0.0f, x2 = 0.0f;
        if ((a == 0 && b == 0) || (disc < 0))
        {
            Console.WriteLine("There is no roots.");
        }
        else if ((a == 0) || (disc == 0))
        {
            Console.WriteLine("There is one root.");
            // calculate root
            if (a == 0)
            {
                x1 = - c / b;
            }
            else if (disc == 0)
            {
                x1 = - b / 2 * a;
            }
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        else
        {
            Console.WriteLine("There is two roots.");
            // calculate roots
            if ((b == 0) && (c * a < 0))
            {
                x1 = (float)Math.Sqrt(-c / a);
                x2 = (float)(-Math.Sqrt(-c / a));
            }
            else if (c == 0)
            {
                x1 = 0;
                x2 = - b / a;
            }
            else
            {
                x1 = (float)(-b - Math.Sqrt(disc)) / 2 * a;
                x2 = (float)(-b + Math.Sqrt(disc)) / 2 * a;
            }
            Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
        }
    }
}
