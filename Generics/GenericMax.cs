using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericMax<T> where T : IComparable
    {
        public T[] value;

        public GenericMax(T[] Value)
        {
            this.value = Value;

        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];

        }

        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("The Maximum value is: " + max);

        }
    }

        
    
}
