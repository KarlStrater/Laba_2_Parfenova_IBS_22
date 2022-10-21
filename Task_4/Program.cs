using Specials;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = F.CreateSize(5, 10);
            int[,] array = Specials.FillArray(arraySize, 1, 10);
            Specials.PrintArray(array);
            Console.WriteLine();
            int summ = Specials.GettingSumm(array);
            Console.WriteLine("Summ that was wanted = " + summ);
        }
    }
}