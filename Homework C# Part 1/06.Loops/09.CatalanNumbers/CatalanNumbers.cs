using System;

class CatalanNumbers
{
    static void Main()
    {
        for (int numberN = 1; numberN < 50; numberN++)
        {
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

            Console.WriteLine(facA / (facB * facC));
        }        
    }
}

