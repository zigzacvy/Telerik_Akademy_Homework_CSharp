using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SemiYoungStudents
{
    class SemiYoungStudents
    {
        static void Main(string[] args)
        {
            var userInput = new[]
            {
                new {firstName="Gosho",lastName="Goshev",Age=15},
                new {firstName="Pesho",lastName="Peshev",Age=24},
                new {firstName="Boncho",lastName="Bonbonchev",Age=22},
                new {firstName="Pipi",lastName="Mihailova",Age=21},
                new {firstName="Ivan",lastName="Stariqt",Age=26},
                new {firstName="Dimityr",lastName="Chichkata",Age=50},
            };

            var outputNames =
                from studetn in userInput
                where studetn.Age >= 18 && studetn.Age <= 24
                select studetn;

            foreach (var name in outputNames)
                Console.WriteLine("{0} {1}",name.firstName, name.lastName);
        }
    }
}

//Write a LINQ query that finds the first name and last name of all
//students with age between 18 and 24.