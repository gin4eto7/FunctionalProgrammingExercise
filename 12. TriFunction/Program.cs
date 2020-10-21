using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, int> funkSum = p => p.Select(c => (int)c).Sum();

            Func<List<string>, int, Func<string, int>, string> resultFunc = (name, n, funk) => name.FirstOrDefault(p => funk(p) >= n);

            string result = resultFunc(names, num, funkSum);

            Console.WriteLine(result);

        }
    }
}
