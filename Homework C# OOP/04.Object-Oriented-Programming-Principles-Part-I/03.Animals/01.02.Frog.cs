using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Frog : Animal, ISound
    {
        public Frog(Animal inputAnimal)
            : base(inputAnimal.age, inputAnimal.name, inputAnimal.sexMale)
        { }

        public void MakeASound()
        {
            Console.WriteLine("asdgfrgh");
        }
    }
}
