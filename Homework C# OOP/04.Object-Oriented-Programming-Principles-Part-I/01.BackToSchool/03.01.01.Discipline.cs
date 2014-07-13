using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BackToSchool
{
    class Discipline : Teacher 
    {
        public string discName { get; set; }
        public uint numOfLectures { get; set; }
        public uint numOfExercises { get; set; }

        public Discipline(Teacher intputTeacher, string inputDiscName, uint inputNumLec, uint inputNumEx)
            : base(intputTeacher)
        {
            this.discName = inputDiscName;
            this.numOfLectures = inputNumLec;
            this.numOfExercises = inputNumEx;
        }
    }
}
