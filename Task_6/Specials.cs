using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specials;
namespace Task_6
{
    internal class Specials
    {
        public static int[] Dupl(int[] array)
        {
            int value = F.GetNeg(array);
            int[] finalArray = new int[array.GetLength(0) + value];
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] >= 0)
                {
                    finalArray[count] = array[i];
                    count++;
                }
                else if (array[i] < 0)
                {
                    finalArray[count] = array[i];
                    count++;
                    finalArray[count] = array[i];
                    count++;
                }
            }
            return finalArray;
        }

    }
}
