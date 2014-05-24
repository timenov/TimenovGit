using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrintDivisibleNumbers
{
    class MainClass
    {
        static void Main()
        {
            int[] arr = new int[100];

            for (int i = 0; i < 100; i++)
            {
                arr[i] = i + 1;
            }

            Console.WriteLine("Divisible numbers by 3 and 7 by Lambda function:");
            foreach (var item in arr.DivisibleNumbersWithLambda())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDivisible numbers by 3 and 7 by LINQ function:");
            foreach (var item in arr.DivisibleNumbersWithLINQ())
            {
                Console.WriteLine(item);
            }
        }
    }
}
