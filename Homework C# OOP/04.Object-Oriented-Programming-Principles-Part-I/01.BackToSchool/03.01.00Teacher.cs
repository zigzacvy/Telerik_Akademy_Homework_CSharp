using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BackToSchool
{
    class Teacher : People
    {
        public Teacher(People inputPerson)
            : base(inputPerson.textIdentifier, inputPerson.personName)
        {
        }
    }
}
