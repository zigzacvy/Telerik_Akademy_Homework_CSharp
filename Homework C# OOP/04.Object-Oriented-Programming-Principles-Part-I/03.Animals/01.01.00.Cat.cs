using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Cat:Animal
    {
        public Cat(Animal inputAnimal)
            :base(inputAnimal.age,inputAnimal.name,inputAnimal.sexMale)
        { }
    }
}
