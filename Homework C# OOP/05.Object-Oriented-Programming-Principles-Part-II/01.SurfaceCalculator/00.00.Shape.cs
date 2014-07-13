using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SurfaceCalculator
{
    public abstract class Shape
    {
        public double widht { get; set; }
        public double height { get; set; }

        public abstract double CalculateShape();
    }
}
