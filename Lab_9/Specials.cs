using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Specials
    {
        public static int[] Fill(int arraySize)
        {
            Random rand = new Random();
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                if (i == 0)
                    array[i] = rand.Next(0, 3);
                else
                    array[i] = array[i - 1] += rand.Next(1, 5);
            }
            return array;
        }
        public static bool Code(int[] arrayOne, int[] arrayTwo)
        {
            bool result = true;
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for(int j=0; j<arrayOne.GetLength(0); j++)
                    if (arrayOne[i] != arrayTwo[j])
                    {
                     result = false;
                     return result;
                    }
            }
            return result;
        }
    }
}