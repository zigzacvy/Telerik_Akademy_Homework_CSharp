using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> userList = new List<Animal>();
            userList.Add(new Dog(new Animal(3, "Pesho", true)));
            userList.Add(new Frog(new Animal(7, "Gosho", true)));
            userList.Add(new Kitten(new Cat(new Animal(2, "Minka", true))));
            userList.Add(new Dog(new Animal(5, "Geri", true)));

            Animal.AverageAge(userList);

            Dog userDog = new Dog(new Animal(15, "Sasho", false));
            userDog.MakeASound();
        }
    }
}
