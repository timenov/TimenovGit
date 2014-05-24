using System;
using System.Collections.Generic;

class ArithmeticalExpression
{
    static Stack<char> operators = new Stack<char>();
    static Stack<int> numbers = new Stack<int>();

    static void Main()
    {
        string expression = Console.ReadLine();
        expression = expression.Replace(" ", "");

        expression = FindAndCalcMathFunctions(expression);
        
        Console.WriteLine(expression);
    }
    static double Action(double a, double b, char sign)
    {
        double answer = 0;
        switch (sign)
        {
            case '+':
                answer = a + b;
                break;
            case '-':
                answer = a - b;
                break;
            case '*':
                answer = a * b;
                break;
            case '/':
                answer = a / b;
                break;
        }
        return answer;
    }
    static string FindAndCalcMathFunctions(string exp)
    {
        while (exp.Contains("pow") || exp.Contains("sqrt") || exp.Contains("ln"))
        {
            exp = FindAndCalcLn(exp);
            exp = FindAndCalcPow(exp);
            exp = FindAndCalcSqrt(exp);
        }
        return exp;
    }
    static string FindAndCalcPow(string exp)
    {
        int index = 0;
        while (exp.IndexOf("pow", index) != -1)
        {
            index = exp.IndexOf("pow", index);
            string temp = exp.Substring(index + 4, exp.IndexOf(')') - (index + 4));
            if (temp[0] < 96 && temp[temp.IndexOf(',') + 1] < 96)
            {
                temp = CalcData(temp, "pow");
                string currentPowerExpression = exp.Substring(index, exp.IndexOf(')') - index + 1);
                exp = exp.Replace(currentPowerExpression, temp);
            }
            index++;
        }
        return exp;
    }
    static string FindAndCalcSqrt(string exp)
    {
        int index = 0;
        while (exp.IndexOf("sqrt", index) != -1)
	    {
            index = exp.IndexOf("sqrt", index);
            string temp = exp.Substring(index + 5, exp.IndexOf(')') - (index + 5));
            if (temp[0] < 96)
            {
                temp = CalcData(temp, "sqrt");
                string currentSqrtExpression = exp.Substring(index, exp.IndexOf(')') - index + 1);
                exp = exp.Replace(currentSqrtExpression, temp);
            }
            index++;
	    }
        return exp;
    }
    static string FindAndCalcLn(string exp)
    {
        int index = 0;
        while (exp.IndexOf("ln", index) != -1)
        {
            index = exp.IndexOf("ln", index);
            string temp = exp.Substring(index + 3, exp.IndexOf(')') - (index + 3));
            if (temp[0] < 96)
            {
                temp = CalcData(temp, "ln");
                string currentSqrtExpression = exp.Substring(index, exp.IndexOf(')') - index + 1);
                exp = exp.Replace(currentSqrtExpression, temp);
            }
            index++;
        }
        return exp;
    }
    static string CalcData(string data, string function)
    {
        double answer = 0.0;
        double number = 0.0;
        switch (function)
	    {
            case "pow":
                double[] numbers = new double[2];
                string[] strNumbers = data.Split(',');
                for (int i = 0; i < strNumbers.Length; i++)
                {
                    numbers[i] = double.Parse(strNumbers[i]);
                }
                answer = Math.Pow(numbers[0], numbers[1]);
                break;
            case "sqrt":
                number = double.Parse(data);
                answer = Math.Sqrt(number);
                break;
            case "ln":
                number = double.Parse(data);
                answer = Math.Log(number);
                break;
	    }
        return answer.ToString();
    }
}