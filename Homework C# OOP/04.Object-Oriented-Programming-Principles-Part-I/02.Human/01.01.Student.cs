using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _02.Human
{
    class Student : Human
    {
        public float grade;

        public Student(Human inputHuman, float inputGrade)
            : base(inputHuman.firstName, inputHuman.lastName)
        {
            this.grade = inputGrade;
        }

        public override List<Student> SortBy(List<Student> inputList)
        {
            var sortedList =
                from student in inputList
                orderby student.grade ascending
                select student;

            List<Student> newList=new List<Student>();
            foreach (var output in sortedList)
                newList.Add(output);

            return newList;    
        }
    }
}
