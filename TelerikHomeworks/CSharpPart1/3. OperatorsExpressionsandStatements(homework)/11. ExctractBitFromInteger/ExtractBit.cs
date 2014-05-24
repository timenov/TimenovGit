using System;

    class ExtractBit
    {
        static void Main()
        {
            Console.Write("Insert number from 0 to 2^32: ");
            uint numb = uint.Parse(Console.ReadLine());

            Console.Write("Which bit you want to extract: ");
            byte pos = byte.Parse(Console.ReadLine());

            int temp = 1 << pos;

            bool isZero = (numb & temp) == 0;

            if (isZero)
            {
                Console.WriteLine("Bit is 0.");
            }
            else
            {
                Console.WriteLine("Bit is 1.");
            }
        }
    }