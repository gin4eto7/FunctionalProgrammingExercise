using System;

namespace _01._ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            Action<string[]> names = arr => Console.WriteLine(String.Join("\n", arr));
            names(arr);
        }

    }
}
