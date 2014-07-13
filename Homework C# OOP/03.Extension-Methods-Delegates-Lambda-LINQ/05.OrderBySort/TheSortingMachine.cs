using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _05.OrderBySort
{
    class TheSortingMachine
    {
        public StudentInfo[] input { get; set; }

        public TheSortingMachine(StudentInfo[] userInput)
        {
            this.input = userInput;
        }

        public void SortingMethod()
        {
            var sortedData = this.input.OrderByDescending(x => x.firstName).ThenByDescending(x => x.lastName);

            foreach(var output in sortedData)
                Console.WriteLine("{0} {1}",output.firstName,output.lastName);
        }

        public void SortingMethodLinq()
        {
            var sortedData =
                from data in this.input
                orderby data.firstName descending, data.lastName descending
                select data;

            foreach(var output in sortedData)
                Console.WriteLine("{0} {1}", output.firstName, output.lastName);
        }
    }
}