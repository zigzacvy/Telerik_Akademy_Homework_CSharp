using System;

class SumOfThree
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        int numberA = int.Parse(Console.ReadLine());

        Console.Write("Enter number b: ");
        int numberB = int.Parse(Console.ReadLine());

        Console.Write("Enter number c: ");
        int numberC = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} + {2} = {3}", numberA, numberB, numberC, numberC+numberB+numberA);
    }
}


//Write a program that reads 3 integer numbers from the console and prints their sum.