using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 127; i++)
        {
            char letter = (char)i;
            Console.WriteLine("Number {0} stands for {1}", i, letter);
        }
    }
}

