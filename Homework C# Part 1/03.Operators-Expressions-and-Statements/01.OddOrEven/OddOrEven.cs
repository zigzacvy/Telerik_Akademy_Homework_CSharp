using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        
        if (firstNumber%2==0)
        {
            Console.WriteLine("Even.");
        }
        else
        {
            Console.WriteLine("Odd.");
        }
    }
}

//Write an expression that checks if given integer is odd or even.