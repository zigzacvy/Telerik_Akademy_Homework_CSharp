using System;

class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        double pi = Math.PI;

        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of the circle is: {0}\nThe perimeter of of the cirle is {1}",
            pi*radius*2, pi*radius*radius);
    }
}

//Write a program that reads the radius r of a circle and prints its perimeter and area.
