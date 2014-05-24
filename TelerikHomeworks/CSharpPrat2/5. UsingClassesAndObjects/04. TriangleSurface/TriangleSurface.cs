//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. 
using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("enter parameters:");
        Console.Write("side a: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("side b: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("side c: ");
        double sideC = double.Parse(Console.ReadLine());
        Console.Write("altitude: ");
        double altitude = double.Parse(Console.ReadLine());
        Console.Write("angle between side a and side b: ");
        float angle = float.Parse(Console.ReadLine());
        
        double surface = CalcSurface(sideA, altitude);
        Console.WriteLine("side and altitude: {0}", surface);
        
        surface = CalcSurface(sideA, sideB, angle);
        Console.WriteLine("two sides and angle between them: {0}", surface);

        surface = CalcSurface(sideA, sideB, sideC);
        Console.WriteLine("three sides: {0}", surface);
    }

    static double CalcSurface(double a, double h)
    {
        double surface = (a * h) / 2;
        return surface;
    }
    static double CalcSurface(double a, double b, float angle)
    {
        double sufrace = (a * b * Math.Sin((Math.PI * angle) / 180) / 2.0);
        return sufrace;
    }
    static double CalcSurface(double a, double b, double c)
    {
        double semiPer = (a + b + c) / 2;
        double surface = Math.Sqrt(semiPer * (semiPer - a) * (semiPer - b) * (semiPer - c));
        return surface;
    }
}