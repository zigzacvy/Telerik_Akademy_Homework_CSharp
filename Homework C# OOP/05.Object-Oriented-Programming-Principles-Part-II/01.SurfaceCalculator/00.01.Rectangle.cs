using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SurfaceCalculator
{
    class Rectangle : Shape
    {
        public override double CalculateShape()
        {
            return base.height * base.widht;
        }
    }
}
