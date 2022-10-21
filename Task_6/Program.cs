using Specials;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = F.CreateSize(5, 10);
            int[] array = F.FillArray(arraySize, -10, 10);
            Console.WriteLine("Array: ");
            F.PrintArray(array);
            int[] final = Specials.Dupl(array);
            Console.WriteLine("\nFinal Array: ");
            F.PrintArray(final);
        }
    }
}