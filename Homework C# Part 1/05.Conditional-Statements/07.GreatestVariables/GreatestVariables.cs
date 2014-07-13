using System;

class GreatestVariables
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers:");

        Console.Write("a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c:");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d:");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e:");
        int e = int.Parse(Console.ReadLine());
        int greatestNumber = a;

        if (greatestNumber < b)
        {
            greatestNumber = b;
        }
        if (greatestNumber < c)
        {
            greatestNumber = c;
        }
        if (greatestNumber < d)
        {
            greatestNumber = d;
        }
        if (greatestNumber < e)
        {
            greatestNumber = e;
        }

        Console.WriteLine("The greatest number is {0}.", greatestNumber);
    }
}

//Write a program that finds the greatest of given 5 variables.