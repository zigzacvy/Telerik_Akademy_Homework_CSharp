using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Euclidian3DSpace
{
    class TestInput
    {
        static void Main(string[] args)
        {
            //Test 1. (TEST)
            int userCoordX = 1;
            int userCoordY = 4;
            int userCoordZ = 2;

            Point3D userTestPoint = new Point3D(userCoordX,userCoordY,userCoordZ);
            Point3D userTestPointTwo = new Point3D(3, 5, 2);

            //Task 2. (TEST)
            Point3D userPointZero = new Point3D();
            Console.WriteLine(userPointZero.PointZero.ToString());

            Console.WriteLine(userTestPoint.ToString());
            Console.WriteLine(userTestPointTwo.ToString());

            //Task 3. (TEST)
            List<int> output = DistCalc.DistanceCalc(userTestPoint, userTestPointTwo);
            DistCalc.DiffPrinter(output);

            //Task 4. (TEST)
            int pathNum = 5;
            Path inputPath = new Path(pathNum);
            //inputPath.pathHolder.Add(userTestPoint);
            //inputPath.pathHolder.Add(userPointZero.PointZero);

            //----------
            //Path.PathListFiller(userTestPoint);
            //Path.PathListFiller(userTestPointTwo);        

            //----------
            string filePath = @"..\..\PathTestInput.txt";
            inputPath = Path.FillFromFile(filePath);
        }
    }
}
