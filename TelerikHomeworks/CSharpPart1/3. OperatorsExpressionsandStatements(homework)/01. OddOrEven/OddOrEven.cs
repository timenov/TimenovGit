// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Type a number between -2^31 and 2^31: ");

        int numb = int.Parse(Console.ReadLine());
            
        if (numb % 2 == 0)
        {
            Console.WriteLine("Number is even.");
        }
        else
        {
            Console.WriteLine("Number is odd.");
        }
    }
}