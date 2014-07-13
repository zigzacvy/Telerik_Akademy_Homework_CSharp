using System;

class Fibonacci
{
    static void Main()
    {
        int a = 1;
        int b = 0;
        int c;

        for (int i = 0; i < 100; i++)
        {
            c = a + b;  
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }
}

//Write a program to print the first 100 members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …