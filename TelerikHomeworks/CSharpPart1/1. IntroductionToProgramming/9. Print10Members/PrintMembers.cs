using System;

class PrintMembers
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 11; i++)
        {
            if ((i % 2) == 1)
            {
                Console.WriteLine(i*(-1));
                continue;
            }
            Console.WriteLine(i);
        }
    }
}