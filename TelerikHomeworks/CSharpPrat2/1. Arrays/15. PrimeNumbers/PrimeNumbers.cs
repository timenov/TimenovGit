//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        int[] array = new int[10000000];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                Console.Write("{0} ", array[i]);
                for (int j = i + array[i]; j < array.Length; j += array[i])
                {
                    array[j] = 0;
                }
            }
        }
    }
}