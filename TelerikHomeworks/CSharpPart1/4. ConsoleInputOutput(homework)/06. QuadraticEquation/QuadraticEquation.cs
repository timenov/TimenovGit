// Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it.

using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter coeff. a: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Enter coeff. b: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Enter coeff. c: ");
            float c = float.Parse(Console.ReadLine());

            float D = b * b - 4 * a * c;

            if (D != 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / 2 * a;
                double x2 = (-b + Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("D = {0}\nx1 = {1}\nx2 = {2}", D, x1, x2);
            }
            else if (D == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("D = {0}\nx1 = x2 = {1}", x);
            }
            else
            {
                Console.WriteLine("The equation has no solution!"); // if discriminant is negative
            }
        }
    }