using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter a:");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter b:");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter c:");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine("{0}*x^2 + {1}*x + {2} = 0; x1 = {3}, x2 = {4}",
            a, b, c, (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a, (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a);

        if ((b * b - 4 * a * c) < 0)
        {
            Console.WriteLine("b * b - 4 * a * c < 0");
        }
        if ((b * b - 4 * a * c).Equals(0))
        {
            Console.WriteLine("b * b - 4 * a * c = 0");
        }
    }
}

//Write a program that enters the coefficients a, b and c of a quadratic equation
//		a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.