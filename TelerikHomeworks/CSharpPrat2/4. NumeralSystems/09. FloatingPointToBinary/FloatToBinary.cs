//Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float). 
using System;
using System.Text;

class FloatToBinary
{
    static int eReminder;
    static string IntegerPart(string n)
    {
        int index = n.IndexOf(".");
        int number = int.Parse(n.Substring(0, index));
        string intPart = Convert.ToString(number, 2);
        return intPart;
    }
    static string FractionalPart(string n)
    {
        bool firstOne;
        if (n[0].Equals('0'))
            firstOne = false;
        else
            firstOne = true;

        int index = n.IndexOf(".");
        float fract = float.Parse(n.Substring(index));
        int digitCount = 0;
        StringBuilder binary = new StringBuilder();
        while (fract != 1.0f && digitCount < 23)
        {
            fract *= 2;
            if (fract >= 1.0f)
            {
                binary.Append("1");
                fract--;
                firstOne = true;
            }
            else
                binary.Append("0");
            if (firstOne)
            {
                digitCount++;
            }
        }
        return binary.ToString();
    }
    static string Mantissa(string n)
    {
        StringBuilder temp = new StringBuilder();
        temp.Append(IntegerPart(n) + ".");
        int dotIndex = temp.Length - 1;
        temp.Append(FractionalPart(n));
        if (temp[0].Equals('1'))
        {
            eReminder = dotIndex - 1;
            temp.Remove(dotIndex, 1);
            temp.Remove(0, 1);
        }
        else
        {
            int indexOfFirstOne = temp.ToString().IndexOf("1");
            eReminder = 1 - indexOfFirstOne;
            temp.Remove(0, indexOfFirstOne + 1);
        }
        return temp.ToString().PadRight(23, '0');
    }
    static string Exponent()
    {
        int e = 127 + eReminder;
        return Convert.ToString(e, 2).PadLeft(8, '0');
    }
    static void Main()
    {
        Console.Write("enter floating-point number: ");
        string number = Console.ReadLine();
        //if input is integer adding a fractional part
        if (!number.Contains("."))
        {
            number += ".0";
        }

        StringBuilder binaryNumber = new StringBuilder();

        if (number[0].Equals('-'))
        {
            binaryNumber.Append("1");
            number = number.Remove(0, 1);
        }
        else
            binaryNumber.Append("0");

        if (float.Parse(number) == 0.0f)
        {
            binaryNumber.Append(new string('0', 32));
        }
        else
        {
            string mantissa = Mantissa(number);
            string e = Exponent();
            binaryNumber.Append(e);
            binaryNumber.Append(mantissa);
        }
        Console.WriteLine("binary representation: {0}", binaryNumber.ToString(0, 32));
    }
}