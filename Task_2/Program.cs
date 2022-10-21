using Specials;

namespace Task_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int arraySize = 3;
            int[,,] array = Specials.CreateArr(arraySize, -10, 10);
            F.PrintArrayTripple(array);
            Specials.Replace(array);
            Console.WriteLine("Array after changes:");
            F.PrintArrayTripple(array);
        }
    }
}