using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericAssignment
{
    class uc4_MoreThenThreeParameter<T> where T : IComparable
    {
       
            public T[] value;
            public uc4_MoreThenThreeParameter(T[] value)
            {
                this.value = value;
            }

            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }

            public T MaxValue(params T[] values)
            {
                var sorted_values = Sort(values);
                return sorted_values[sorted_values.Length - 1];
            }
        
    }
}
