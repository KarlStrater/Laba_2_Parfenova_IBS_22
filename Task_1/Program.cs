using Specials;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = F.CreateSize(5, 15);
            int[] array = F.FillArray(arraySize, 1, 100);
            Console.WriteLine("Array in the beggining:");

            F.PrintArray(array);

            Console.WriteLine("\nArray after sorting:");

            Specials.sorting(array);
            F.PrintArray(array);
        }
    }
}