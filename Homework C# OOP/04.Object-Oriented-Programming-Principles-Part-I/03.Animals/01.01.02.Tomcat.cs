using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Tomcat : Cat, ISound
    {
        public Tomcat(Cat inputAnimal)
            : base(inputAnimal)
        {
            base.sexMale = true;
        }

        public void MakeASound()
        {
            Console.WriteLine("miau");
        }
    }
}
