using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());
        int sum = 0;

        int a = 1;
        int b = 0;
        int c;

        for (int i = 0; i < numberN; i++)
        {
            c = a + b;
            a = b;
            b = c;
            sum += c;
        }

        Console.WriteLine(sum);
    }
}

