// Write a program that safely compares floating-point numbers with precision of 0.000001

using System;

class CompareNumbers
{
    static void Main(string[] args)
    {
        // for precision of 0.000001 appropriate type is float

        Console.Write("insert first floating-point number: ");
        float firstNumb = float.Parse(Console.ReadLine());

        Console.Write("insert second floating-point number: ");
        float secondNumb = float.Parse(Console.ReadLine());

        bool areEquals = (firstNumb == secondNumb);

        Console.WriteLine(areEquals);
    }
}