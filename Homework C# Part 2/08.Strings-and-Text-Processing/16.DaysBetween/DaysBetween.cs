using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DaysBetween
{
    class DaysBetween
    {
        static void Main(string[] args)
        {
            string firstDate = "18.11.2000";
            string secondDate = "18.11.2013";

            DateTime startDate = DateTime.ParseExact(firstDate, "dd.mm.yyyy", CultureInfo.InvariantCulture);
            DateTime finalDate = DateTime.ParseExact(secondDate, "dd.mm.yyyy", CultureInfo.InvariantCulture);

            double distance = (finalDate - startDate).TotalDays;

            Console.WriteLine(distance);
        }
    }
}

//Write a program that reads two dates in the format: day.month.year and calculates the
//number of days between them. Example: