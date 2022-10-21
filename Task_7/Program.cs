using Specials;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the size of the array");
            int size = F.IntTryParse();
            int[] array = new int[size]; 
            Console.WriteLine("Array: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Write the number:"+ (i + 1));
                int value = F.IntTryParse();
                array[i] = value;
            }
            Console.WriteLine("Array:");
            F.PrintArray(array);
            Specials.sorting(array);
            Console.WriteLine("Final array:");
            F.PrintArray(array);
        }
    }
}