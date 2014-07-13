using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Student userStudOne = new Student("Georgi", "Vasilev", "Petrov", 1234567890, 1234567890, "asd@asd.asd", 3,
                Student.Universities.technicalUniversity, Student.Faculties.mechanicalEngineering, Student.Specialties.mechatronics);
            Student userStudTwo = new Student("Petyr", "Georgiev", "Vasilev", 1324567890, 1234567098, "asd@dsa.asd", 2,
                Student.Universities.sofiqUniversity, Student.Faculties.phisics, Student.Specialties.nuclearPhysics);

            //Methods test
            string toStringTest = userStudOne.ToString();
            int getHashCodeTest = userStudOne.GetHashCode();
            bool equalsTest = userStudOne.Equals(userStudTwo);
            bool operatorsTestOne = userStudOne == userStudTwo;
            bool operatorsTestTwo = userStudOne != userStudTwo;
            Student cloneTest = (Student)userStudTwo.Clone(); //Clone() returns object, that's why I'm casting to Student.

            Console.WriteLine(toStringTest);
            Console.WriteLine("-------------\n-------------");
            Console.WriteLine(getHashCodeTest); //No idea...
            Console.WriteLine(equalsTest);
            Console.WriteLine(operatorsTestOne);
            Console.WriteLine(operatorsTestTwo);
            Console.WriteLine("-------------\n-------------");
            Console.WriteLine(cloneTest.ToString());
            Console.WriteLine(userStudOne.CompareTo(userStudTwo));
        }
    }
}
