// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class CheckPoint
{
    static void Main()
    {
        Console.WriteLine("Please insert coordinates for point:");
        Console.Write("x -> ");
        float x = float.Parse(Console.ReadLine());

        Console.Write("y -> ");
        float y = float.Parse(Console.ReadLine());

        bool isFromCircle = (x * x + y * y) < (5.0 * 5.0); // Pythagorean theorem

        Console.WriteLine("\nIs point within a circle? {0}", isFromCircle);
    }
}