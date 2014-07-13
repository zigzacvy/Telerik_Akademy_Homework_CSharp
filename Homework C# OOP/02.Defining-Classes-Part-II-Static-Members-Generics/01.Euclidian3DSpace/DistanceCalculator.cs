using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Euclidian3DSpace
{
    static class DistCalc
    {
        //Task 3.
        public static List<int> DistanceCalc(Point3D pointOne, Point3D pointTwo)
        {
            int distX;
            int distY;
            int distZ;

            if (pointOne.coordX > pointTwo.coordX)
            {
                distX = pointOne.coordX - pointTwo.coordX;
            }
            else distX = pointTwo.coordX - pointOne.coordX;

            if (pointOne.coordY > pointTwo.coordY)
            {
                distY = pointOne.coordY - pointTwo.coordY;
            }
            else distY = pointTwo.coordY - pointOne.coordY;

            if (pointOne.coordZ > pointTwo.coordZ)
            {
                distZ = pointOne.coordZ - pointTwo.coordZ;
            }
            else distZ = pointTwo.coordZ - pointOne.coordZ;

            List<int> coordDiff = new List<int>();
            coordDiff.Add(distX);
            coordDiff.Add(distY);
            coordDiff.Add(distZ);

            return coordDiff;
        }

        public static void DiffPrinter(List<int> userCoordDiff)
        {
            Console.WriteLine("The difference between\nX coordinates {0}, between\nY coordinates {1}, between\nZ coordinates {2}"
                , userCoordDiff[0], userCoordDiff[1], userCoordDiff[2]);
        }
    }
}
