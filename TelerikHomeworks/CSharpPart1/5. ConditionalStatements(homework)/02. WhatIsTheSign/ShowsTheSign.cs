// Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
using System;

class ShowsTheSign
{
    static void Main()
    {
        Console.WriteLine("Please enter three real numbers:");

        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());

        bool aIsPositive = a > 0;
        bool bIsPositive = b > 0;
        bool cIsPositive = c > 0;
        bool product = (aIsPositive ^ bIsPositive ^ cIsPositive);

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("Product is 0.");
        }
        else if (product)
        {
            Console.WriteLine("Product is positive.");
        }
        else
        {
            Console.WriteLine("Product is negative.");
        }
    }
}