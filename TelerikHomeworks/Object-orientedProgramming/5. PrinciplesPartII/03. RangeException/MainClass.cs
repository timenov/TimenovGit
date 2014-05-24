using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeException
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                GetNumber(int.Parse(Console.ReadLine()));
                GetData(new DateTime(1999, 2, 2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void GetNumber(int number)
        {
            int min = 0, max = 100;
            if (number > max || number < min)
            {
                throw new InvalidRangeException<int>("The number is not in range", min, max);
            }
            else
            {
                Console.WriteLine("Success");
            }
        }

        static void GetData(DateTime date)
        {
            DateTime min = new DateTime(1980, 1, 1);
            DateTime max = new DateTime(2013, 12, 31);

            if (date > max || date < min)
            {
                throw new InvalidRangeException<DateTime>("The date is not in range", min, max);
            }
            else
            {
                Console.WriteLine("Success");
            }
        }
    }
}
