using System;

class CatalanNumberN
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());

        double facA = 1;
        for (int i = 1; i <= numberN * 2; i++)
        {
            facA *= (double)i;
        }

        double facB = 1;
        for (int f = 1; f <= numberN + 1; f++)
        {
            facB *= (double)f;
        }

        double facC = 1;
        for (int j = 1; j <= numberN; j++)
        {
            facC *= (double)j;
        }

        Console.WriteLine("The N number from Catalan Numbers is {0}.", facA / (facB * facC));
    }
}

