using System;

class ProgramThatCalculates
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());
        int numberK;
        do
        {
            Console.Write("Enter K (1< K< N): ");
            numberK = int.Parse(Console.ReadLine());
        }
        while (!(numberK < numberN && numberK > 1));

        double factorialN = 1;
        for (int i = 1; i <= numberN; i++)
        {
            factorialN *= (double)i;
        }

        double factorialK = 1;
        for (int k = 1; k <= numberK; k++)
        {
            factorialK *= (double)k;
        }

        Console.WriteLine("N! / K! = {0}", factorialN / factorialK);
    }
}

