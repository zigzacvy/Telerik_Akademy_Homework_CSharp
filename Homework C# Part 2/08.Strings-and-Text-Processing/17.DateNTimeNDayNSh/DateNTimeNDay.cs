using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.DateNTimeNDayNSh
{
    class DateNTimeNDay
    {
        static void Main(string[] args)
        {
            string userDate = "3.9.2013 17:00:00";

            DateTime dateAfter = DateTime.ParseExact(userDate, "d.M.yyyy HH:mm:ss", new CultureInfo("bg-BG"));

            dateAfter = dateAfter.AddHours(6.5);
            string dayOfTheWeek = dateAfter.ToString("dddd", new CultureInfo("bg-BG"));

            Console.WriteLine(dayOfTheWeek + " " + dateAfter);
        }
    }
}

//Write a program that reads a date and time given in the format: day.month.year
//hour:minute:second and prints the date and time after 6 hours and 30 minutes 
//(in the same format) along with the day of week in Bulgarian.