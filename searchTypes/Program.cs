// See https://aka.ms/new-console-template for more information

namespace searchTypes
{
    class Program
    {
        static void Main()
        {
            BinarySearch bs = new BinarySearch();

            bs.LinearSearch();
            bs.binarySearch();
            bs.InterpolationSearch();

            Console.ReadKey();
        }
    }
}