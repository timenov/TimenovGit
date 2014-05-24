// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class CheckPointCoordinates
{
    static void Main()
    {
        Console.WriteLine("Please insert coordinates for point:");
        Console.Write("x -> ");
        float x = float.Parse(Console.ReadLine());

        Console.Write("y -> ");
        float y = float.Parse(Console.ReadLine());

        bool isFromCircle = (x * x + y * y) < (4 * 4); // Pythagorean theorem

        bool xIsNotFromRect = ((x < -1) || (x > 5));
        bool yIsNotFromRect = ((y > 1) || (y < -1));
        bool pointIsNotFromRect = xIsNotFromRect || yIsNotFromRect;

        Console.WriteLine("Point is within circle. {0}", isFromCircle);
        Console.WriteLine("Point is outside rectangle. {0}", pointIsNotFromRect);
    }
}