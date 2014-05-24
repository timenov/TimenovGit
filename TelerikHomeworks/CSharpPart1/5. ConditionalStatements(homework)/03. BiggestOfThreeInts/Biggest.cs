// Write a program that finds the biggest of three integers using nested if statements.
using System;

class Biggest
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers:");

        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());

        if ((a > b && a > c) || (a == b && a > c) || (a > b && a == c))
            Console.WriteLine("{0} is biggest", a);
        else if ((b > a && b > c) || (b == a && b > c) || (b > a && b == c))
            Console.WriteLine("{0} is biggest", b);
        else if ((c > a && c > b) || (c == a && c > b) || (c > a && c == b))
            Console.WriteLine("{0} is biggest", c);
        else
            Console.WriteLine("numbers are equals");
    }
}