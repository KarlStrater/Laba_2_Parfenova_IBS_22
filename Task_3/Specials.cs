using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Specials
    {
        public static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] >= 0)
                    sum += array[i];
            return sum;
        }
    }
}
