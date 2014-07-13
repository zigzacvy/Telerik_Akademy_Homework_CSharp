using System;

class Sequence
{
    static void Main()
    {
        for (int i = 0; i < 10; i=i+1)
        {
            Console.WriteLine((i + 2) * (Math.Pow(-1, i)));
        }
    }
}

