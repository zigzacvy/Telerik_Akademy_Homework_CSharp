using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SurfaceCalculator
{
    class Circle : Shape
    {
        public override double CalculateShape()
        {
            base.height = base.widht;

            return Math.Pow((base.widht/2),2) * Math.PI;
        }
    }
}
