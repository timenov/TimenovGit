using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonProject
{
    class MainClass
    {
        static void Main()
        {
            Person[] persons = new Person[] { new Person("Pesho", 23),
                                                new Person("Gosho") };

            foreach (var item in persons)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}
