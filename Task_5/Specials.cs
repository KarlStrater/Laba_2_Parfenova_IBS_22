using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specials;

namespace Task_5
{
    internal class Specials
    {
        public static int[] Delete(int[] array)
        {
            int value = F.GetNeg(array);
            int[] final = new int[array.GetLength(0) - value];
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                if (array[i] > -1)
                {
                    final[count] = array[i];
                    count++;
                }
            return final;
        }
    }
}
