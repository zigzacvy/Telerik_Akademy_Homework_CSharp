using System;

class PintInSircle
{
    static void Main()
    {
        Console.WriteLine("Enter the x coordinate of the point \"A\":");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the y coordinate of the point \"A\":");
        float y = float.Parse(Console.ReadLine());

        if ((Math.Sqrt((x * x) + (y * y))) <= 5)
        {
            Console.WriteLine("The point \"A\" is within the cicrle.");
        }
        else
        {
            Console.WriteLine("The point \"A\" is outside the cicrle.");
        }
    }
}

//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).