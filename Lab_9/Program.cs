using Specials;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Randomly filled arrays");
                    int size = F.CreateSize(5, 10);
                    int[] first = Specials.Fill(size);
                    int[] second = Specials.Fill(size);
                    Console.WriteLine("First array:");
                    F.PrintArray(first);
                    Console.WriteLine("\nSecond array");
                    F.PrintArray(second);
                    if (Specials.Code(first, second))
                    {
                        Console.WriteLine("\nArrays are equal");
                        return;
                    }
                    Console.WriteLine("\nArrays are not equal");
        }
    }
}