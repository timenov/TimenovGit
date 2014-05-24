using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace _02.ExtensionMethodsForIEnumerable
{
    class MainClass
    {
        static void Main()
        {
            IEnumerable<long> list = new List<long>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Product());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Average());
        }
    }
}
