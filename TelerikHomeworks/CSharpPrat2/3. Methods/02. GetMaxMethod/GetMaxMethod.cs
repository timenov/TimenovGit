//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
using System;

class GetMaxMethod
{
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static void Main()
    {
        Console.WriteLine("insert three integers:");
        int[] numbers = new int[3]; // store three numbers in array
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max;
        max = GetMax(numbers[0], numbers[1]); //compare first and second
        max = GetMax(max, numbers[2]); // compare bigger from first and second with third number
        Console.WriteLine("biggest number is {0}", max);
    }
}