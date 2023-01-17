using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaximumFloatNumbers
    {
        public static double MaximumFloatNumbers(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine("firstValue: " + firstValue);
                return firstValue;
            }

            if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0)
            {
                Console.WriteLine("secondValue: " + secondValue);
                return secondValue;
            }

            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(firstValue) > 0)
            {
                Console.WriteLine("thirdValue: " + thirdValue);
                return thirdValue;
            }
            Console.WriteLine("firstValue: " + firstValue);
            return firstValue;
        }

    }
}

