using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class MainClass
    {
        public static void Main()
        {
            GenericList<int> testList = new GenericList<int>(1);
            testList.Add(23);
            testList.Add(34);
            testList.Add(45);
            testList.Add(56);
            testList.Add(67);
            testList.Add(78);
            testList.InsertAt(111, testList.Count);
            
            Console.WriteLine(Max<int>(testList));
        }

        public static T Min<T>(GenericList<T> list) where T : IComparable<T>
        {
            T min = list.Get(0);
            for (int i = 1; i < list.Count; i++)
            {
                if (min.CompareTo(list.Get(i)) > 0)
                {
                    min = list.Get(i);
                }
            }
            return min;
        }
        public static T Max<T>(GenericList<T> list) where T : IComparable<T>
        {
            T max = list.Get(0);
            for (int i = 1; i < list.Count; i++)
            {
                if (max.CompareTo(list.Get(i)) < 0)
                {
                    max = list.Get(i);
                }
            }
            return max;
        }
    }
}
