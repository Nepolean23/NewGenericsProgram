using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaximumIntegersNumbers
    {
        public static int MaximumIntegerNumbers(int firstValue, int secondValue, int thirdValue)
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

