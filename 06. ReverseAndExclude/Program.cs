using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());

            numbers = numbers.Where(x => x % num != 0).ToList();
            numbers.Reverse();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
