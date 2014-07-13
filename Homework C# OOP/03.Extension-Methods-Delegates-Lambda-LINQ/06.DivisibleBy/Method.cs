using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _06.DivisibleBy
{
    class Method
    {
        public int[] array { get; set; }

        public Method(int[] userArray)
        {
            this.array = userArray;
        }

        public void DivisibleBy()
        {
            var output = this.array.Where(x => x % 3 == 0 && x % 7 == 0);

            foreach (var item in output)
                Console.WriteLine(item);
        }

        public void DivisbleByLinq()
        {
            var output =
                from num in this.array
                where num % 3 == 0 && num % 7 == 0
                select num;

            foreach (var item in output)
                Console.WriteLine(item);
        }
    }
}
