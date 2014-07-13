using System;

class MinAndMax
{
    static void Main()
    {
        Console.Write("Enter the number of figures: ");
        int number = int.Parse(Console.ReadLine());

        int max = 0;
        int min = 0;        
        
        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter figure:");
            int figure = int.Parse(Console.ReadLine());
            
            if (i==1)
            {
                max = figure;
                min = figure;
            }
           
            if (min > figure)
            {
                min = figure;
            }
           
            if (max < figure)
            {
                max = figure;
            }

        }

        Console.WriteLine("Minimal number: " + min);
        Console.WriteLine("Maximal number: " + max);
    }   
}

