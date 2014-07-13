using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter number N < 20: ");
        int numberN = int.Parse(Console.ReadLine());
       
        int startNumber = 0;

        for (int i = 0; i < numberN; i++)
        {
            for (int j = 1; j <= numberN; j++)
            {
                Console.Write(j + startNumber + " ");
            }
            Console.WriteLine();
            startNumber++;
        }
    }
}

