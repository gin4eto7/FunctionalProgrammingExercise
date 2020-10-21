using System;
using System.Linq;

namespace _03._CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minNum = n => n.Min();

            Console.WriteLine(minNum(numbers));


        }
    }
}
