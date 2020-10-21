using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            names = names.Where(x => x.Length <= length).ToArray();

            Console.WriteLine(String.Join("\n", names));
        }
    }
}
