// Sort 3 real values in descending order using nested if statements.
using System;

class Sort
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers:");

        Console.Write("a = ");
        int big = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int midd = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int small = int.Parse(Console.ReadLine());

        int temp = 0;

        // first take "big" like the greatest, and if it is not, exchange value with real greatest number
        if (midd > big)
        {
            temp = big;
            big = midd;
            midd = temp;
        }
        if (small > big)
        {
            temp = big;
            big = small;
            small = temp;
        }

        // compare second and third numbers
        if (small > midd)
        {
            temp = midd;
            midd = small;
            small = temp;
        }

        Console.WriteLine("{0}, {1}, {2}", big, midd, small);
    }
}