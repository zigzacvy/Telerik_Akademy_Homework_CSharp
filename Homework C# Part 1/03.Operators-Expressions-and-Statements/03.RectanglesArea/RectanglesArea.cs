using System;

class RectanglesArea
{
    static void Main()
    {
        Console.WriteLine("Enter the height of the rectangle:");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the widht of the rectangle:");
        float width = float.Parse(Console.ReadLine());
        
        Console.WriteLine("The area of the rectangle is: {0}", height * width);
    }
}

//Write an expression that calculates rectangle’s area by given width and height.