using System;

class ExchangeBitsB
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int numb = int.Parse(Console.ReadLine());

        Console.Write("Please enter p: ");
        byte p = byte.Parse(Console.ReadLine());

        Console.Write("Please enter q: ");
        byte q = byte.Parse(Console.ReadLine());

        Console.Write("Please enter k: ");
        byte k = byte.Parse(Console.ReadLine());

        string str = null;
        for (int i = 1; i <= k; i++)
        {
            str += "1";
        }

        int maskLength = Convert.ToInt32(str, 2);
        
        int sMask = maskLength << p; // s from small
        int bMask = maskLength << --q; // b from big

        int xOrMasks = sMask ^ bMask;
        int xOrMasksAndNumb = xOrMasks & numb;

        int numbAndSMask = numb & sMask;
        int numbAndBMask = numb & bMask;

        int temp = (numbAndSMask << 20) ^ (numbAndBMask >> 20);

        int tempXORNumb = temp ^ numb;

        int finalResult = tempXORNumb ^ xOrMasksAndNumb;

        Console.WriteLine("Enter Number: {0}", Convert.ToString(numb, 2).PadLeft(32, '0'));
        Console.WriteLine("Change Number:{0}", Convert.ToString(finalResult, 2).PadLeft(32, '0'));
        Console.WriteLine(finalResult);
    }
}