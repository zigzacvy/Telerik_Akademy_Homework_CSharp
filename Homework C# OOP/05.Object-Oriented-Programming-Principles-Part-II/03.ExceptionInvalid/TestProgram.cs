using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExceptionInvalid
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For number enter 1, for date enter 2.");

            int userSwitch = int.Parse(Console.ReadLine());
            switch (userSwitch)
            {
                case 1:
                    Console.WriteLine("Enter number: ");
                    GetNumber(1, 100);
                    break;

                case 2:
                    Console.WriteLine("Enter date in format  dd/mm/yy : ");
                    GetDate(new DateTime(1980, 1, 1), new DateTime(1980, 12, 31));
                    break;
            }
        }

        public static DateTime GetDate(DateTime minValue, DateTime maxValue)
        {
            try
            {
                DateTime date = DateTime.Parse(Console.ReadLine());
                if (date > minValue || date < maxValue)
                {
                    throw new InvalidRangeException<DateTime>("Date Out Of Range", minValue, maxValue);
                }
                return date;
            }
            catch (InvalidRangeException<DateTime> E)
            {
                Console.WriteLine(E.message);
            }

            return new DateTime();
        }

        public static int GetNumber(int minValue, int maxValue)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num > minValue || num < maxValue)
                {
                    throw new InvalidRangeException<int>("Int Out Of Range", minValue, maxValue);
                }
                return num;
            }
            catch (InvalidRangeException<int> E)
            {
                Console.WriteLine(E.message);
            }

            return 0;
        }
    }
}
