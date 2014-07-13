using System;

class BitPosition
{
    static void Main()
    {
        Console.WriteLine("Enter the position \"p\" of the bit counting from 0:");
        double position = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number \"v\":");
        int number = int.Parse(Console.ReadLine());
        
        if ((number & (int)Math.Pow(2, (position - 1))).Equals((int)Math.Pow(2, (position - 1))))
        {
            Console.WriteLine("There is 1 on position \"p\". True!");
        }
        else
        {
            Console.WriteLine("There is 0 on postion \"p\". False!");
        }
    }
}

//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.