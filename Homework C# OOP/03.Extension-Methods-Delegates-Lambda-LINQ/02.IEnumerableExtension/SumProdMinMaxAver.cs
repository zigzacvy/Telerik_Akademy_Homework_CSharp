using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtension
{
    public static class SumProdMinMaxAver
    {
        public static T Sum<T>(this IEnumerable<T> userInput) where T : IComparable
        {
            dynamic sum = 0;

            foreach (var item in userInput)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> userInput) where T : IComparable
        {
            dynamic prod = 1;

            foreach (var item in userInput)
            {
                prod *= item;
            }

            return prod;
        }

        public static T Average<T>(this IEnumerable<T> userInput) where T : IComparable
        {
            dynamic prod = userInput.Product();
            dynamic aver = prod / userInput.Count();

            return aver;
        }

        public static T Min<T>(this IEnumerable<T> userInput) where T : IComparable
        {
            dynamic min;

            if (userInput is string[] || userInput is List<string>)
            {
                min = "                                                           ";
                foreach (var item in userInput)
                {
                    if (item.ToString().Length < min.ToString().Length)
                    {
                        min = item;
                    }
                }
                return min;
            }

            else
            {
                min = userInput.ElementAt(0);
                foreach (var item in userInput)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            }
        }

        public static T Max<T>(this IEnumerable<T> userInput) where T : IComparable
        {
            dynamic max;

            if (userInput is string[] || userInput is List<string>)
            {
                max = "";
                foreach (var item in userInput)
                {
                    if (item.ToString().Length > max.ToString().Length)
                    {
                        max = item;
                    }
                }
                return max;
            }

            else
            {
                max = userInput.ElementAt(0);
                foreach (var item in userInput)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
                return max;
            }
        }
    }
}
