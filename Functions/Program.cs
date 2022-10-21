namespace Specials
{
    public static class F
    {
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
        }

        public static void PrintArrayTripple(int[,,] array)
        {
            for (int z = 0; z < array.GetLength(0); z++)
            {
                Console.WriteLine("layer:"+ (z + 1) +" ");
                for (int y = 0; y < array.GetLength(0); y++)
                {
                    for (int x = 0; x < array.GetLength(0); x++)
                    {
                        Console.Write(array[x, y, z]+" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public static int CreateSize(int begin, int end)
        {
            Random rand = new Random();
            int arraySize = rand.Next(begin, end);
            Console.WriteLine("ArraySize = " + arraySize);
            return arraySize;
        }
        public static int[] FillArray(int arraySize, int begin, int end)
        {
            Random rand = new Random();
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = rand.Next(begin, end);
            }
            return array;
        }
        public static int GetNeg(int[] array)
        {
            int value = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] < 0)
                {
                    value++;
                }
            }
            return value;
        }
        public static int IntTryParse()
        {
            int result = 0;
            bool tr = true;
            while (tr)
            {
                bool successful = int.TryParse(Console.ReadLine(), out result);
                if (!successful)
                {
                    Console.WriteLine("Write the number");
                }
                else
                {
                    if (result < 0)
                    {
                        Console.WriteLine("Wrong imput");
                    }
                    else
                    {
                        tr = false;
                    }
                }
            }
            return result;
        }
    }
}