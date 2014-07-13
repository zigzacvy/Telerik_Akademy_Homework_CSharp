using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BackToSchool
{
    class People : Class
    {
        public string personName { get; set; }

        public People(string inputClassId, string inputName)
            : base(inputClassId)
        {
            this.personName = inputName;
        }
    }
}
