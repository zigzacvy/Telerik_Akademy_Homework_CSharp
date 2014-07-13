using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SurfaceCalculator
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Shape[] userArr = new Shape[] {
                new Rectangle() {height=3,widht=2},
                new Rectangle() {height=5,widht=4},
                new Circle() {widht=6},
                new Triangle() {height=8,widht=4}
            };        

            foreach(Shape figure in userArr)
            {
                Console.WriteLine("The shape is {0}, it's area is {1}",
                    figure.GetType().Name,
                    figure.CalculateShape()
                    );
            }
        }
    }
}
