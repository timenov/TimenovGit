// Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
using System;

class NumberToText
{
    static void Main()
    {
        string[] ones = { "\b\0\b\b\0\b\0\b\b\0", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] tens = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] others = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 10) // 0 to 9
        {
            if (num == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine(ones[num]);
            }
        }
        else if (num > 9 && num < 20) // 10 to 19
        {
            Console.WriteLine(others[num % 10]);
        }
        else if (num > 19 && num < 100) // 20 to 99
        {
            Console.WriteLine("{0}    {1}", tens[num / 10], ones[num % 10]);
        }
        else if (num == 100)
        {
            Console.WriteLine("one hundred");
        }
        else if (num > 100 && num < 1000) // 101 to 999
        {
            Console.Write("{0} hundred ", ones[num / 100]);
            byte midd = (byte)((num / 10) % 10); // find middle digit 
            byte last = (byte)((num % 10) % 10); // find last digit
            if (midd == 0) // *00 to *09
            {
                Console.WriteLine("and {0}", ones[last]);
            }
            else if (midd == 1) // *10 to *19
            {
                Console.WriteLine("and {0}", others[last]);
            }
            else // *20 to *99
            {
                Console.WriteLine("{0} {1}", tens[midd], ones[last]);
            }
        }
    }
}