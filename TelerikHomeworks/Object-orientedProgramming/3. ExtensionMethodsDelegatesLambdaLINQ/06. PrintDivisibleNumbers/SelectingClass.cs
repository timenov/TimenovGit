using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrintDivisibleNumbers
{
    public static class SelectingClass
    {
        public static int[] DivisibleNumbersWithLambda(this int[] arr)
        {
            return arr.Where(x => ((x % 21 == 0))).ToArray();
        }

        public static int[] DivisibleNumbersWithLINQ(this int[] arr)
        {
            return new List<int>(from item in arr
                                    where item % 21 == 0
                                    select item).ToArray();
        }
    }
}
