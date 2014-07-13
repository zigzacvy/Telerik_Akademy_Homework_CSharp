using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TodayShower
{
    class CurrentDayPrinter
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Today;
            Console.WriteLine("Today is {0}.",currentDate.DayOfWeek);
        }
    }
}

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.