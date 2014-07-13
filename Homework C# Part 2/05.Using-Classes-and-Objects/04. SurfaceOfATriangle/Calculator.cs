using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SurfaceOfATriangle
{
    class Calculator
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(@"Enter ""1"" if you want to find triangle's surface by side and 
an altitude, ""2"" for two sides and angle and ""3"" for three sides.");

                int number = 0;
                do
                {
                    Console.Write("Enter 1, 2 or 3: ");
                    number = int.Parse(Console.ReadLine());
                } while (number > 3);

                switch (number)
                {
                    case 1:
                        Console.Write("Enter side: ");
                        float userSide = float.Parse(Console.ReadLine());
                        Console.Write("Enter altitutde to the entered side: ");
                        float userAltitude = float.Parse(Console.ReadLine());
                        AltitudeSide(userAltitude, userSide);
                        break;

                    case 2:
                        Console.Write("Enter side A: ");
                        double userSideA = double.Parse(Console.ReadLine());
                        Console.Write("Enter side B: ");
                        double userSideB = double.Parse(Console.ReadLine());
                        Console.Write("Enter the angle between them: ");
                        double userAngleDeg = double.Parse(Console.ReadLine());
                        TwoSidesAngle(userSideA, userSideB, userAngleDeg);
                        break;

                    case 3:
                        Console.Write("Enter side A: ");
                        double userSideAa = double.Parse(Console.ReadLine());
                        Console.Write("Enter side B: ");
                        double userSideBb = double.Parse(Console.ReadLine());
                        Console.Write("Enter side C: ");
                        double userSideCc = double.Parse(Console.ReadLine());
                        ThreeSides(userSideAa, userSideBb, userSideCc);
                        break;
                }
            }
        }

        public static float AltitudeSide(float altitude, float side)
        {
            float surface = (side * altitude) / 2;
            Console.WriteLine("The surface of the triangle is {0}.", surface);
            return surface;
        }

        public static double TwoSidesAngle(double sideA, double sideB, double degrees)
        {
            double angle = Math.PI * degrees / 180.0;
            double surface = (sideA * sideB * Math.Sin(angle)) / 2;
            Console.WriteLine("The surface of the triangle is {0}.", surface);
            return surface;
        }

        public static double ThreeSides(double sideA, double sideB, double sideC)
        {
            double per = sideA + sideB + sideC;
            double surface = Math.Sqrt(per * (per - sideA) * (per - sideB) * (per - sideC));
            Console.WriteLine("The surface of the triangle is {0}.", surface);
            return surface;
        }
    }
}


//Write a program that calculate the surface of triangle by given:
//Side and altitude to it; three sides; two sides and an angle between them.
//Use System.Math.