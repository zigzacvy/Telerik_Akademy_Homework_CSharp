using System;

class TrapezoidsArea
{
    static void Main()
    {
        Console.WriteLine("Enter side a of the trapezoid:");
        float sideA = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b of the trapezoid:");
        float sideB = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height h of the trapezoid:");
        float heightH = float.Parse(Console.ReadLine());

        Console.WriteLine("The area of the trapezoid is: {0}", ((sideA + sideB) * heightH) / 2);
    }
}

//Write an expression that calculates trapezoid's area by given sides a and b and height h.