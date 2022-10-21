using Specials;
namespace Task_3 {
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = F.CreateSize(5, 15);
            int[] array = F.FillArray(arraySize, -10, 10);
            F.PrintArray(array);
            int sum = Specials.GetSum(array);
            Console.WriteLine("\nSumm of all not negative numbers of the array = " + sum);
        }
    }
}
