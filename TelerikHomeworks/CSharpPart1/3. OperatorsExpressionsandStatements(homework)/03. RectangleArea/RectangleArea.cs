// Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Please insert rectangle's width: ");
        float width = float.Parse(Console.ReadLine());

        Console.Write("Please insert rectangle's height: ");
        float height = float.Parse(Console.ReadLine());

        float area = (width * height) / 2;
        Console.WriteLine("Area is: {0}", area);
    }
}