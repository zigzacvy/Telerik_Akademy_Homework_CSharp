using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforeLast
{
    class FirstBeforeLast
    {
        static void Main(string[] args)
        {
            string[] inputNames = { "Ana Babina", "Tosho Goshev",
                                "Pesho Jorev", "Vanq Toshkova",
                                "Iana Toshkova","Asq Joreva"};

            var rightNames =
                from name in inputNames
                where name.Split(' ')[0][0] < name.Split(' ')[1][0]
                select name;

            foreach (var item in rightNames)
                Console.WriteLine(item);
        }
    }
}

//Write a method that from a given array of students finds all
//students whose first name is before its last name alphabetically.
//Use LINQ query operators.