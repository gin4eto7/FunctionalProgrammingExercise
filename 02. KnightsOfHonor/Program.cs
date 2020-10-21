using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split().ToList();
            arr = arr.Select(s => $"Sir {s}").ToList();

            Action<string[]> names = a => Console.WriteLine(String.Join("\n", a));
            names(arr.ToArray());
        }

    }
}
