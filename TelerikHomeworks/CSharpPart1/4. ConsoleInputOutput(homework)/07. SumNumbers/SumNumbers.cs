// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

    class SumNumbers
    {
        static void Main()
        {
            Console.Write("How many numbers you want to enter: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("You want to enter {0} numbers.", n);

            float sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("enter number ({0}): ", i);
                sum += float.Parse(Console.ReadLine());
            }

            Console.WriteLine("The sum is: {0}", sum);
        }
    }