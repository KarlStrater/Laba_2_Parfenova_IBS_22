using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Specials
    {
        internal static int[,] FillArray(int arraySize, int begin, int end)
        {
            Random rand = new Random();
            int[,] array = new int[arraySize, arraySize];
            for (int i = 0; i < arraySize; i++)
                for (int j = 0; j < arraySize; j++)
                    array[i, j] = rand.Next(begin, end);
            return array;
        }

        internal static int GettingSumm(int[,] array)
        {
            int sum = 0;
            for(int i=0; i<array.GetLength(0); i++)
                for(int j=0; j<array.GetLength(0); j++)
                    if((i+j)%2==0)
                        sum+=array[i,j];
            return sum;
        }

        internal static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(0); j++)
                    Console.Write(array[i, j] + " ");
            }
                Console.WriteLine();
        }
    }
}
