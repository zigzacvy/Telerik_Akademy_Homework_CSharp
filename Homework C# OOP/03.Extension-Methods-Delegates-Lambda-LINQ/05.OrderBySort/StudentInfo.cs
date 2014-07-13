using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OrderBySort
{
    class StudentInfo
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public StudentInfo(string inputFirstName, string inputLastName)
        {
            this.firstName = inputFirstName;
            this.lastName = inputLastName;
        }
    }
}
