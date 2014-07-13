using System;

class ProgramThatCalculates
{
    static void Main()
    {
        Console.Write("Enter number K: ");
        int numberK = int.Parse(Console.ReadLine());
        int numberN;
        do
        {
            Console.Write("Enter N (1< N< K): ");
            numberN = int.Parse(Console.ReadLine());
        }
        while (!(numberN < numberK && numberN > 1));

        double factorialN = 1;
        for (int n = 1; n <= numberN; n++)
        {
            factorialN *= (double)n;
        }

        double factorialK = 1;
        for (int k = 1; k <= numberK; k++)
        {
            factorialK *= (double)k;
        }

        int KminusN = numberK - numberN;
        double facKminN = 1;
        for (int i = 1; i <= KminusN; i++)
        {
            facKminN *= (double)i;
        }

        Console.WriteLine("(N! * K!) / (K - N)! = {0}", (factorialN * factorialK) / facKminN);
    }
}

