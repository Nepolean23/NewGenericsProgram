using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     public class GenericMaximum <T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;

        public GenericMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public static T MaximumString(T firstString, T secondString, T thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                ((firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(secondString) > 0 ||
                   firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)))

            {
                Console.WriteLine("firstString: " + firstString);
                return firstString;
            }

            if (secondString.CompareTo(thirdString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                ((secondString.CompareTo(thirdString) >= 0 && secondString.CompareTo(secondString) > 0 ||
                   secondString.CompareTo(thirdString) > 0 && secondString.CompareTo(thirdString) >= 0)))
            {
                Console.WriteLine("secondString: " + secondString);
                return secondString;
            }

            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(firstString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(firstString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(firstString) >= 0)

            {
                Console.WriteLine("thirdString: " + thirdString);
                return thirdString;
            }
            Console.WriteLine("firstString: " + firstString);
            return firstString;
        }

        public T MaxMethod()
        {
            T max= GenericMaximum<T>.MaximumString(this.firstValue,this.secondValue,this.thirdValue);
            return max;

        }

    }

}

