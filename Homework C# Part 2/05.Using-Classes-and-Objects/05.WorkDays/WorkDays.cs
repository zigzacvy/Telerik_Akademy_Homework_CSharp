using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WorkDays
{
    class WorkDays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date (YYYY/MM/DD): ");
            string dateArr = Console.ReadLine();
            DateTime userDate = DateTime.Parse(dateArr);
            DateTime now = DateTime.Today;
            int difference = Math.Abs((now - userDate).Days);

            Console.WriteLine("There are {0} days from now {2} till {1}.", difference, userDate.ToShortDateString(), now);

            WorkingDaysCounter(now, userDate, difference);
        }

        private static void WorkingDaysCounter(DateTime now, DateTime final, int lenghtPer)
        {
            int counter = lenghtPer;

            DateTime[] holydays ={
                                    new DateTime(2001,1,1),
                                    new DateTime(2001,4,6),
                                    new DateTime(2001,4,24),
                                    new DateTime(2001,12,24),
                                };

            for (DateTime i = now; i < final; i = i.AddDays(1d))
            {
                for (int j = 0; j < holydays.Length; j++)
                {
                    if (i.Month == holydays[j].Month && i.Day == holydays[j].Day) counter--;
                }
            }

            for (int i = 0; i < lenghtPer; i++)
            {
                if (final > now)
                {

                    now = now.AddDays(1);
                    if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
                    {
                        counter--;
                    }
                }
                else
                {
                    final = final.AddDays(1);
                    if (final.DayOfWeek == DayOfWeek.Saturday || final.DayOfWeek == DayOfWeek.Sunday)
                    {
                        counter--;
                    }
                }
            }

            Console.WriteLine("The number of working days is {0}.", counter);
        }
    }
}


//Write a method that calculates the numbers of workdays between today and given date, 
//passed as parameter. Consider that workdays are all days from Monday to Fridey
//except a fixed list of publick holidays specified preliminary as array.