using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Person userPersonOne = new Person("Gosho");
            Person userPersonTwo = new Person("Teodor", 30);

            string testPersonOne = userPersonOne.ToString();
            string testPersonTwo = userPersonTwo.ToString();

            Console.WriteLine(testPersonOne);
            Console.WriteLine(testPersonTwo);
        }
    }
}
