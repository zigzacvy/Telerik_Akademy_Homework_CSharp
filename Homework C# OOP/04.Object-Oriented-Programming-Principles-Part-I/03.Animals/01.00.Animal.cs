using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Animal
    {
        public uint age { get; set; }
        public string name { get; set; }
        public bool sexMale { get; set; }

        public Animal() { }

        public Animal(uint inputAge, string inputName, bool inputSex)
        {
            this.age = inputAge;
            this.name = inputName;
            this.sexMale = inputSex;
        }

        public static void AverageAge(List<Animal> inputList)
        {
            uint sum=0;

           foreach(var item in inputList)
           {
               sum += item.age;
           }

           Console.WriteLine(sum/inputList.Count());                
        }
    }
}
