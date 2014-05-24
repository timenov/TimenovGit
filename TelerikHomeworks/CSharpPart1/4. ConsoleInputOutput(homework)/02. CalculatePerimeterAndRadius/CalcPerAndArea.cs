// Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CalcPerAndArea
{
    static void Main()
    {
        Console.Write("Insert a raduis of circle: ");
        float r = float.Parse(Console.ReadLine());

        float per = (float)Math.PI * r * 2;
        float area = (float)Math.PI * r * r;

        Console.WriteLine("Perimeter is: {0}", per);
        Console.WriteLine("Area is: {0}", area);
    }
}