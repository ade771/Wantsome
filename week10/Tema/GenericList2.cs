using System;
using System.Collections.Generic;
using System.Text;

namespace TemaGeneric
{
     public class GenericList2
    {
       
        public T Max<T>(params T[] values) where T : IComparable<T>
        {
         T max = values[0];
           for (int i = 0; i < values.Length; i++)
               if (values[i].CompareTo(max) > 0) max = values[i];
           return max;
        }

        public T Min<T>(params T[] values) where T : IComparable<T>
        {
            T min = values[0];
            for (int i = 0; i < values.Length; i++)
                if (values[i].CompareTo(min) < 0) min = values[i];
            return min;
        }




    }
}
