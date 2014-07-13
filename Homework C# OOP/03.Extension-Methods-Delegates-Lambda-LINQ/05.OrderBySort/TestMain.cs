using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OrderBySort
{
    class TestMain
    {
        static void Main(string[] args)
        {
            StudentInfo[] userInput=
            {
                new StudentInfo("Gosho","Goshev"),
                new StudentInfo("Pesho","Peshev"),
                new StudentInfo("Boncho","Bonbonchev"),
                new StudentInfo("Pipi","Mihailova"),
                new StudentInfo("Ivan","Stariqt"),
            };     
            
            TheSortingMachine output=new TheSortingMachine(userInput);
            output.SortingMethod();
            Console.WriteLine("LINQ -----------");
            output.SortingMethodLinq();
        }
    }
}

//Using the extension methods OrderBy() and ThenBy() with lambda 
//expressions sort the students by first name and last name in 
//descending order. Rewrite the same with LINQ.