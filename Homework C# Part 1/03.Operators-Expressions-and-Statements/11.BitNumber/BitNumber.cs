using System;

class BitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the number \"i\":");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number \"b\" of the bit counting from 0:");
        double position = double.Parse(Console.ReadLine());

        if ((number & (int)Math.Pow(2, (position - 1))).Equals((int)Math.Pow(2, (position - 1))))
        {
            Console.WriteLine("There is 1 on position \"b\".");
        }
        else
        {
            Console.WriteLine("There is 0 on postion \"b\".");
        }
    }
}

//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.