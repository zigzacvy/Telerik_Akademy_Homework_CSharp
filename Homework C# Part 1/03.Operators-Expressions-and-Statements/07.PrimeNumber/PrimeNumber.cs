using System;

class PrimeNumber
{
    static void Main()
    {
        int randomNumber;
        do
        {
            Console.WriteLine("Enter number \"n\" (n<100):");
            randomNumber = int.Parse(Console.ReadLine());
        }
        while (!(randomNumber <= 100));

        Console.WriteLine(@"If ""n"" can be divided by an integer number less than sqrt(n), different of 1 it's not prime.
        ");

        for (int i = 2; i < Math.Sqrt(randomNumber); i++)
        {
            if ((randomNumber % i) != 0)
            {
                Console.WriteLine("One number can't be divided.");
            }
            else
            {
                Console.WriteLine("One number can be divided.");
            }

        }
    }
}

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.