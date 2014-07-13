using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person
{
    class Person
    {
        //Fields
        public string name { get; set; }
        public byte? age { get; set; }

        //Constructor
        public Person(string inputName)
        {
            this.name = inputName;
        }

        public Person(string inputName, byte inputAge)
        {
            this.name = inputName;
            this.age = inputAge;
        }

        //Method
        public override string ToString()
        {
            StringBuilder personInfo = new StringBuilder();

            personInfo.AppendLine(this.name);
            if(age!=null)
            {
                personInfo.AppendLine(this.age.ToString());
            }
            else
            {
                personInfo.AppendLine("Age not assigned!");
            }

            return personInfo.ToString();
        }
    }
}
