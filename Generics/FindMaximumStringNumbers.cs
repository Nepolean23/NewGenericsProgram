﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaximumStringNumbers
    {
        public static String MaximumString(String firstString, String secondString, String thirdString)
        {
            if  (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                ((firstString.CompareTo(secondString)>=0 && firstString.CompareTo(secondString)>0 ||
                   firstString.CompareTo(secondString)>0 && firstString.CompareTo(thirdString)>=0)))

            {
                Console.WriteLine("firstString: " + firstString);
                return firstString;
            }

            if (secondString.CompareTo(thirdString) > 0 && secondString.CompareTo(thirdString)> 0 ||
                ((secondString.CompareTo(thirdString)>= 0 && secondString.CompareTo(secondString)> 0||
                   secondString.CompareTo(thirdString)> 0 && secondString.CompareTo(thirdString)>= 0)))
            {
                Console.WriteLine("secondString: " + secondString);
                return secondString;
            }

            if (thirdString.CompareTo(firstString)> 0 && thirdString.CompareTo(firstString)>0||
                thirdString.CompareTo(firstString)>= 0 && thirdString.CompareTo(firstString)>0||
                thirdString.CompareTo(firstString)> 0 && thirdString.CompareTo(firstString)>=0)

            {
                Console.WriteLine("thirdString: " + thirdString);
                return thirdString;
            }
            Console.WriteLine("firstString: " + firstString);
            return firstString;
        }

    }
}
