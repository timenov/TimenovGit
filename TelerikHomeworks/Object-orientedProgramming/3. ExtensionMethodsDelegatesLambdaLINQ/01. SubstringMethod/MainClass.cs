using System;
using System.Text;

namespace _01.SubstringMethod
{
    class MainClass
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 15; i++)
            {
                sb.Append((char)(i + 'a'));
            }

            Console.WriteLine(sb.Substring(2, 33));
            Console.WriteLine(sb.Substring(10));
        }
    }
}
