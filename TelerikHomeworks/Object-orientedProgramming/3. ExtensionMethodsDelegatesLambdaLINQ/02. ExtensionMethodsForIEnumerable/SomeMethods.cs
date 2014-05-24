using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.ExtensionMethodsForIEnumerable
{
    public static class SomeMethods
    {
        public static T Sum<T>(this IEnumerable<T> list)
            where T : IComparable
        {
            dynamic sum = 0;

            foreach (var item in list)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> list)
            where T : IComparable
        {
            dynamic product = 1;

            foreach (var item in list)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> list)
            where T : IComparable
        {
            dynamic min = list.First();

            foreach (var item in list)
            {
                if (min > item)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> list)
            where T : IComparable
        {
            dynamic max = list.First();

            foreach (var item in list)
            {
                if (max < item)
                {
                    max = item;
                }
            }

            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> list)
            where T : IComparable
        {
            dynamic sum = 0;
            decimal count = 0;

            foreach (var item in list)
            {
                sum += item;
                count++;
            }
            
            return sum / count;
        }
    }
}
