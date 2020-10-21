using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = nums[0];
            int end = nums[1];
            List<int> list = new List<int>();

            for (int i = start; i <= end; i++)
            {
                list.Add(i);
            }
            string command = Console.ReadLine();

            Predicate<int> odd = n => n % 2 != 0;
            Predicate<int> even = n => n % 2 == 0;
            List<int> newList = new List<int>();

            if(command == "odd")
            {
                newList = list.FindAll(odd);
            }
            else if(command == "even")
            {
                newList = list.FindAll(even);
            }

            Console.WriteLine(String.Join(" ", newList));
        }
    }
}
