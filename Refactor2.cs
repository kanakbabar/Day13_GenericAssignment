using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericAssignment
{
    
    
        public class Refactor2<T> where T : IComparable
        {
            public T[] value;
            public Refactor2(T[] value)
            {
                this.value = value;
            }

            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;

            }

            void add(params int[] a)
            {

            }


            public T MaxValue(params T[] values)
            {
                var sorted_values = Sort(values);

                return sorted_values[sorted_values.Length - 1];
            }

            public T MaxMethod()
            {
                var max = MaxValue(this.value);
                return max;
            }

            public void PrintMaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum value is " + max);
            }

        internal static int MaximumIntegerNumber(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }
        
        internal static float MaxFloatNumber(float v1, float v2, float v3)
        {
            throw new NotImplementedException();
        }

        internal static string MaximumStringNumber(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
    
}
