using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> print = x => Console.WriteLine(String.Join(" ", x));

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                if(command == "add")
                {
                    numbers = numbers.Select(x => x + 1).ToList();
                }
                else if(command == "multiply")
                {
                    numbers = numbers.Select(x => x * 2).ToList();
                }
                else if(command == "subtract")
                {
                    numbers = numbers.Select(x => x - 1).ToList();
                }
                else if(command == "print")
                {
                    print(numbers);
                }

                command = Console.ReadLine();
            }

        }

    }
}
