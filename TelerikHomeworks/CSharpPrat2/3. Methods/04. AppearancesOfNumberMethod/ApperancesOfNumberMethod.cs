//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.
using System;

class AppearancesOfNumberMethod
{
    static int AppearancesOfMethod(int number, int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        Console.Write("enter array length: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("enter elements");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("enter number you looking for: ");
        int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine("number {0} is appears {1} times", number, AppearancesOfMethod(number, array));
    }
}