//Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter arrays length: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] firstArr = new int[arrLength];
        int[] secondArr = new int[arrLength];
            
        Console.WriteLine("\nEnter first array elements:");
        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nEnter second array elements:");
        for (int i = 0; i < secondArr.Length; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        for (int i = 0; i < firstArr.Length; i++)
        {
            if (firstArr[i] > secondArr[i])
            {
                Console.WriteLine("{0} > {1}", firstArr[i], secondArr[i]);
            }
            else if (firstArr[i] < secondArr[i])
            {
                Console.WriteLine("{0} < {1}", firstArr[i], secondArr[i]);
            }
            else
            {
                Console.WriteLine("{0} = {1}", firstArr[i], secondArr[i]);
            }
        }
    }
}