using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human
{
    public abstract class Human
    {
        public string firstName;
        public string lastName;

        public Human(string inputFirstName, string inputLastName)
        {
            this.firstName = inputFirstName;
            this.lastName = inputLastName;
        }

        public abstract List<Human> SortBy(List<Human> inputList);
    }
}
