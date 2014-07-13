using System;

class Loopception
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter number X: ");
        int numberX = int.Parse(Console.ReadLine());
        double division = 0;
        double sum = 0;

        for (int i = 1; i <= numberN; i++)
        {

            int facI = 1;
            for (int f = 1; f <= i; f++)
            {
                facI *= f;
            }
            division = (double)facI / (numberX * i);
            sum += division;
        }
        Console.WriteLine("S = 1 + (1! / 1 * X) + (2! / 2 * X) + ... + (N! / X * N) = {0}", sum);
    }
}

