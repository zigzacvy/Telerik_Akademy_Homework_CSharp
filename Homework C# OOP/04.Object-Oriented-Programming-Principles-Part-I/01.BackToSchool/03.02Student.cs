using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BackToSchool
{
    class Student : People
    {
        public uint classNumber { get; set; }

        public Student(People inputPerson, uint inputNumber)
            : base(inputPerson.textIdentifier, inputPerson.personName)
        {
            this.classNumber = inputNumber;
        }
    }
}
