//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class BinSearchMethod
{
    static void Main()
    {
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        // filling the array
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);

        int index = -1;
        if (k > array[0])
        {
            while (index < 0)
            {
                index = Array.BinarySearch(array, k--);
            }
            Console.WriteLine("\n{0}", array[index]);
        }
        else
        {
            Console.WriteLine("K is smaller than first element from the array!");
        }
    }
}