using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Euclidian3DSpace
{
    struct Point3D
    {
        //Task 1.
        public int coordX { get; set; }
        public int coordY { get; set; }
        public int coordZ { get; set; }


        public Point3D(int inputCoordX, int inputCoordY, int inputCoordZ)
            : this()
        {
            this.coordX = inputCoordX;
            this.coordY = inputCoordY;
            this.coordZ = inputCoordZ;
        }

        public override string ToString()
        {
            string pointPosition = string.Format("X coordinate: {0}\nY coordinate: {1}\nZ coordinate: {2}\n----------------",
                this.coordX, this.coordY, this.coordZ);

            return pointPosition;
        }

        //Task 2.
        static private Point3D pointZero = new Point3D(0, 0, 0);

        public Point3D PointZero
        {
            get { return pointZero; }
        }
    }
}


