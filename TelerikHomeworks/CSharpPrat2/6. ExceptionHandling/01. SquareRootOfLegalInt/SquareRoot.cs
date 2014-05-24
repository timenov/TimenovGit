//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.
using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("enter positive integer: ");
        uint number;
        try
        {
            number = uint.Parse(Console.ReadLine());
            Console.WriteLine("square root of {0} is {1}", number, Math.Sqrt(number));
        }
        catch (SystemException se) //catch any exceptions
        {
            Console.WriteLine("Invalid number! {0}\n", se.Message); //print message for specific exception
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}