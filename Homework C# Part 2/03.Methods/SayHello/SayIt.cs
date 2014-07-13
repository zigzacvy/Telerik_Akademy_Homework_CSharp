using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    public class SayIt
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");       
            string name = Console.ReadLine();         
            PrintHello(name);
        }

        public static string PrintHello(string printName)
        {
            Console.WriteLine("Hello, {0}!", printName);
            return printName;            
        }
    }
}


//Write a method that asks the user for his name and prints “Hello,
//<name>” (for example, “Hello, Peter!”). Write a program to test this method.