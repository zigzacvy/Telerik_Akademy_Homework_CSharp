using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BackToSchool
{
    class MainTest
    {
        static void Main(string[] args)
        {
            List<Teacher> inputTeachers = new List<Teacher>();
            inputTeachers.Add(new Teacher(new People("8a", "Georgi Petrov")));
            inputTeachers.Add(new Teacher(new People("9a", "Petyr Georgiev")));
            inputTeachers.Add(new Teacher(new People("12b", "Todor Stoichev")));

            List<Student> inputStudent = new List<Student>();
            inputStudent.Add(new Student( new People("8a","Ivan Geqtarski"),12));
            inputStudent.Add(new Student(new People("8a", "Lepa Pepa"), 2));

            Discipline inputDiscipline = new Discipline(inputTeachers[1], "math", 2, 4);
            //Discipline inputDisciplineII = new Discipline(inputStudent[0], "biologie", 2, 0); //Work only with teachers.

            inputStudent[1].AddComment("Doesn't pay attention in class.");
            inputTeachers[0].AddComment("Teaches nothing.");

            Console.WriteLine();
        }
    }
}
