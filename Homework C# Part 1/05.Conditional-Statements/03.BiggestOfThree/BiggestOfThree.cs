using System;

class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");

        Console.Write("a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c:");
        int c = int.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("The greatest number is {0}.", a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("The greatest number is {0}.", b);
        }
        else if (c >= a && c >= b)
        {
            Console.WriteLine("The greatest number is {0}.", c);
        }

        else
        {
            Console.WriteLine("The numbers are equal.");
        }
    }
}

//Write a program that finds the biggest of three integers using nested if statements.