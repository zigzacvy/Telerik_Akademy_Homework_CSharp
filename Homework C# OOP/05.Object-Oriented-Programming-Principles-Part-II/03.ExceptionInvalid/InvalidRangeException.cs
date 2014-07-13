using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExceptionInvalid
{
    class InvalidRangeException<T> : ApplicationException
    {
        public T maxValue { get; set; }
        public T minValue { get; set; }
        public string message { get; set; }

        public InvalidRangeException(string message, T inputMax,T inputMin)
            :base(message)
        {
            this.maxValue = inputMax;
            this.minValue = inputMin;
            this.message = base.Message + "Values must be outside " + minValue + " " + maxValue;
        }
    }
}
