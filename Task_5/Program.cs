using Specials;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = F.CreateSize(5, 10);
            int[] array = F.FillArray(arraySize, -10, 10);
            F.PrintArray(array);
            int[] final = Specials.Delete(array);
            Console.WriteLine();
            F.PrintArray(final);
        }
    }
}