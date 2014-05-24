//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit;
//the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Text;

class AddNumbersMethod
{
    static string ToString(int[] array)
    {
        StringBuilder strNumber = new StringBuilder();
        for (int i = 0; i < array.Length; i++)
        {
            strNumber.Append(array[i]);
        }
        return strNumber.ToString();
    }
    static int[] Trim(int[] array)
    {
        int endIndex = array.Length - 1;
        //check for "waste" zeroes from right
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] != 0)
            {
                endIndex = i;
                break;
            }
        }
        int[] newArray = new int[endIndex + 1];
        for (int i = 0; i <= endIndex; i++)
        {
            newArray[i] = array[i];
        }
        return newArray;
    }
    static int[] ToReverseArray(string number)
    {
        char[] digits = number.ToCharArray();
        int[] allDigits = new int[10000]; //condition is for 10000 digits
        int index = 0;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            allDigits[index] = int.Parse(digits[i].ToString());
            index++;
        }
        return allDigits;
    }
    static int[] Sum(string a, string b)
    {
        int[] first = ToReverseArray(a);
        int[] second = ToReverseArray(b);
        int[] answer = new int[10001];
        for (int i = 0; i < first.Length; i++)
        {
            int temp = first[i] + second[i];
            answer[i] += temp;
            if (answer[i] > 9)
            {
                answer[i] %= 10;
                answer[i + 1] = 1;
            }
        }
        answer = Trim(answer);
        Array.Reverse(answer);
        return answer;
    }

    static void Main(string[] args)
    {
        Console.Write("enter first number: ");
        string a = Console.ReadLine();
        Console.Write("enter second number: ");
        string b = Console.ReadLine();
        
        int[] arr = Sum(a, b);
        Console.WriteLine(ToString(arr));
    }
}