using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _02.Human
{
    class Worker:Human
    {
        public uint WeekSalary { get; set; }
        public uint WorkHoursPerDay { get; set; }

        public Worker(Human inputHuman, uint inputSalary, uint inputHours)
            :base(inputHuman.firstName,inputHuman.lastName)
        {
            this.WeekSalary = inputSalary;
            this.WorkHoursPerDay = inputHours;
        }

        public float MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay * 5;
        }

        public override List<Worker> SortBy(List<Worker> inputList)
        {
            var sortedList =
                from worker in inputList
                orderby worker.WeekSalary descending
                select worker;

            List<Worker> newList = new List<Worker>();
            foreach (var output in sortedList)
                newList.Add(output);

            return newList;
        }
    }
}
