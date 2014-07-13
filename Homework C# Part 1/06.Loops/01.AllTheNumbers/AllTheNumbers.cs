using System;

class AllTheNumbers
{
    static void Main()
    {
        Console.Write("Enter radnom number n:");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine();
    }
}

