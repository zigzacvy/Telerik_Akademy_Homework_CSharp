using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LeapYearChecker
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an year you want to check if it's leap: ");
            int wantedYear = int.Parse(Console.ReadLine());

            Console.WriteLine(DateTime.IsLeapYear(wantedYear));            
        }
    }
}

//Write a program that reads a year from the console and 
//checks whether it is a leap. Use DateTime.