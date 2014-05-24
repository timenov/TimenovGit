// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapeziodArea
{
    static void Main()
    {
        Console.WriteLine("Please insert trapeziod's parameters:");

        Console.Write("side a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("side b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("h: ");
        float h = float.Parse(Console.ReadLine());

        float area = (a + b) / 2 * h;

        Console.WriteLine("Tha area is: {0}", area);
    }
}