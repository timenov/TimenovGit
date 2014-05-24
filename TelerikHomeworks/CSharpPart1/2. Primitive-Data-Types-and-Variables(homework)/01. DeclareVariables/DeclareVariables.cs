// Declare five variables choosing for each of them the most appropriate of the types...
// to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort firstNumb = 52130; // ushort (0 to 65535)
        sbyte secondNumb = -115; // sbyte (-128 to 127)
        int thirdNumb = 4825932; // int (under -2 billion to over 2 billion)
        byte fourthNumb = 97; // sbyte also is appropriate
        short fifthNumb = -10000; // short (-32768 to 32767)

        Console.WriteLine("Numbers are: {0}, {1}, {2}, {3}, {4}", 
            firstNumb, secondNumb, thirdNumb, fourthNumb, fifthNumb);
    }
}
