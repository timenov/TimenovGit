//11. Write a method that adds two polynomials.
//12. Extend the program to support also subtraction and multiplication of polynomials.
using System;
using System.Collections.Generic;
using System.Text;

class Polynomials
{
    static string ToString(int[] array)
    {
        StringBuilder output = new StringBuilder();
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] != 0)
            {
                if (array[i] > 0 && i < array.Length - 1)
                {
                    output.Append("+");
                }
                //print coef: if coef = 1 => x if coef = 2,3 etc. => 2x,3x etc.
                if (array[i] == 1 && i != 0)
                {
                    output.Append("x");
                }
                else
                {
                    output.Append(array[i] + "x");
                }
                //print power
                if (i > 1)
                {
                    output.Append("^" + i);
                }
                else if (i < 1)
                {
                    output.Append("\b\0");
                }
            }
        }
        output = output.Replace("+", " + ");
        output = output.Replace("-", " - ");
        return output.ToString();
    }
    static string[] Split(string s)
    {
        List<string> list = new List<string>();
        int start = 0;
        int end = 0;
        string temp;

        for (int i = 0; i < s.Length; i++)
        {
            if (s.Substring(i, 1).Equals("+") || s.Substring(i, 1).Equals("-"))
            {
                end = i;
                temp = s.Substring(start, end - start);
                start = end;
                list.Add(temp.Replace(" ", ""));
            }
        }

        end = s.Length;
        temp = s.Substring(start, end - start);
        list.Add(temp.Replace(" ", ""));
        if (list[0].Equals(""))
        {
            list.RemoveAt(0);
        }
        return list.ToArray();
    }
    static int Length(string s)
    {
        s = s.Trim();
        int length = 1;
        if (s.Contains("x"))
        {
            if (s.IndexOf('x') == s.Length - 1)
            {
                length = 2;
            }
            else
            {
                string temp = s.Substring(s.IndexOf('^') + 1);
                length = int.Parse(temp) + 1;
            }
        }
        return length;
    }
    static int[] ToArray(string s)
    {
        s = s.ToLower();
        string[] temp = Split(s);
        int[] outputArray = new int[Length(temp[0])];
        int power = 0;
        int coef = 0;
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            //last polynom
            if (!temp[i].Contains("x"))
            {
                coef = int.Parse(temp[i]);
                power = 0;
            }
            else
            {
                if (temp[i].Length > 1 && temp[i].Substring(0, 2).Equals("-x"))
                {
                    temp[i] = temp[i].Replace("-", "-1");
                }
                else if (temp[i].IndexOf('x') == 0)
                {
                    temp[i] = "1" + temp[i];
                }
                coef = int.Parse(temp[i].Substring(0, temp[i].IndexOf('x')));

                power = 0;
                if (temp[i].IndexOf('x') == temp[i].Length - 1)
                {
                    power = 1;
                }
                else
                {
                    string cal = temp[i].Substring(temp[i].IndexOf('^') + 1);
                    power = int.Parse(cal);
                }
            }
            outputArray[power] = coef;
        }
        return outputArray;
    }
    static int[] Sum(string first, string second)
    {
        int[] a = ToArray(first);
        int[] b = ToArray(second);
        int length = Math.Max(a.Length, b.Length);
        int[] sum = new int[length];
        for (int i = 0; i < length; i++)
        {
            int x, y;
            if (i < a.Length)
                x = a[i];
            else
                x = 0;
            if (i < b.Length)
                y = b[i];
            else
                y = 0;
            sum[i] = x + y;
        }
        return sum;
    }
    static int[] Substract(string first, string second)
    {
        int[] a = ToArray(first);
        int[] b = ToArray(second);
        int length = Math.Max(a.Length, b.Length);
        int[] substract = new int[length];
        for (int i = 0; i < length; i++)
        {
            int x, y;
            if (i < a.Length)
                x = a[i];
            else
                x = 0;
            if (i < b.Length)
                y = b[i];
            else
                y = 0;
            substract[i] = x - y;
        }
        return substract;
    }
    static int[] Multiply(string first, string second)
    {
        int[] a = ToArray(first);
        int[] b = ToArray(second);
        if (a.Length > b.Length)
            return Multiplying(a, b);
        else
            return Multiplying(b, a);
    }
    static int[] Multiplying(int[] longest, int[] shortest)
    {
        int length = longest.Length + shortest.Length + 1;
        int[] product = new int[length];
        for (int i = 0; i < longest.Length; i++)
        {
            for (int j = 0; j < shortest.Length; j++)
            {
                product[i + j] += longest[i] * shortest[j];
            }
        }
        return product;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("enter polynoms in this format (x^2 - x + 2) with or without spaces betwen polynoms");
        Console.Write("enter first polynomial: ");
        string first = Console.ReadLine();
        Console.Write("enter second polynomial: ");
        string second = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("({0}) + ({1})", first, second);
        Console.WriteLine(ToString(Sum(first, second)));
        Console.WriteLine();
        Console.WriteLine("({0}) - ({1})", first, second);
        Console.WriteLine(ToString(Substract(first, second)));
        Console.WriteLine();
        Console.WriteLine("({0}) * ({1})", first, second);
        Console.WriteLine(ToString(Multiply(first, second)));
    }
}