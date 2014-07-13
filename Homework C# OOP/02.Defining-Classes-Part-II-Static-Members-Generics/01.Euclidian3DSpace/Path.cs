using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Euclidian3DSpace
{
    //Task 4.
    class Path
    {
        public List<Point3D> pathHolder { get; set; }

        public Path(int userPathNum)
        {
            this.pathHolder = new List<Point3D>(userPathNum);
        }

        //----------
        static private Path userPath = new Path(0);       

        //public static void PathListFiller(Point3D userPoint)
        //{
        //    userPath.Add(userPoint);
        //}

        //----------
        public static Path FillFromFile(string userFilePath)
        {
            StreamReader readFromTxt = new StreamReader(userFilePath);
            string[] inTxtText;

            using (readFromTxt)
            {
                inTxtText = readFromTxt.ReadToEnd().Split('\n');
            }

            for (int i = 0; i < inTxtText.Length; i++)
            {
                Point3D coordFromTxt = new Point3D
                    (
                    (int)char.GetNumericValue(inTxtText[i][0]), 
                    (int)char.GetNumericValue(inTxtText[i][1]), 
                    (int)char.GetNumericValue(inTxtText[i][2])
                    );
                userPath.pathHolder.Add(coordFromTxt);
            }
            return userPath;
        }
    }
}
