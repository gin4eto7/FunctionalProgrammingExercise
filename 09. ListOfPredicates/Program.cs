using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, List<int>, int> 
            int end = int.Parse(Console.ReadLine());
            List<int> listOfNumbers = Console.ReadLine().Split()
                .Select(int.Parse).Distinct().ToList();
            List<int> newList = new List<int>();

            for (int i = 1; i <= end; i++)
            {
                foreach (var num in listOfNumbers)
                {
                    
                    if(predic(i))
                    {
                        newList.Add(i);
                        break;
                    }
                }
            }
        }
    }
}
