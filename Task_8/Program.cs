using Specials;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the size of the array");
            int size = F.IntTryParse();
            Console.WriteLine("Write the number to find its' places");
            int finding=F.IntTryParse();
            int[] array = new int[size];
            Console.WriteLine("Array: ");
            array = F.FillArray(size, 0, 10);
            F.PrintArray(array);
            Console.WriteLine();
            Specials.Finding(array, finding);
        }
    }
}