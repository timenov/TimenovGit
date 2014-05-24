using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitArray64
{
    class MainClass
    {
        static void Main()
        {
            BitArray number = new BitArray(ulong.MaxValue);

            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            Console.WriteLine(number[63]); //last bit of binary representation
        }
    }
}
