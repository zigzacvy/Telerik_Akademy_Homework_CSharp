using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringReverser
{
    class StringReverser
    {
        static void Main(string[] args)
        {
            Console.Write("Enter something: ");
            string userString = Console.ReadLine();

            Console.Write("The string in reverse is: ");
            for (int i = userString.Length-1; i > -1; i--)
            {
                Console.Write(userString[i]);
            }

            Console.WriteLine();
        }
    }
}

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".