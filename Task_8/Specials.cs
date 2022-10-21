using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Specials
    {
        internal static void Finding(int[] array, int finding)
        {
            bool found = false;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == finding)
                {
                    Console.Write((i + 1) + " ");
                    found = true;
                }
            if (!found)
                Console.WriteLine("There's no desired numbers");
        }
    }
}
