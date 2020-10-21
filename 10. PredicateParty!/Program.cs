using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Func<string, string, bool> startsWithFunc = (name, str) => name.StartsWith(str);
            Func<string, string, bool> endsWithFunc = (name, str) => name.EndsWith(str);
            Func<string, int, bool> lengthFunc = (name, length) => name.Length == length;

            string[] namesArr = Console.ReadLine().Split();
            for (int i = 0; i < namesArr.Length; i++)
            {
                names.Add(namesArr[i]);
            }

            string command = Console.ReadLine();
            while (command != "Party!")
            {
                string[] commands = command.Split();
                string theCommand = commands[0];
                string criteria = commands[1];

                if (theCommand == "Double")
                {
                    switch (criteria)
                    {
                        case "StartsWith":
                            string str = commands[2];
                            var currStart = names.Where(name => startsWithFunc(name, str))
                                .ToList();
                            foreach (var currName in currStart)
                            {
                                int index = names.IndexOf(currName);
                                names.Insert(index, currName);
                            }
                            break;
                        case "EndsWith":
                            string str2 = commands[2];
                            var currEnd = names.Where(name => endsWithFunc(name, str2))
                                .ToList();
                            foreach (var currName in currEnd)
                            {
                                int index = names.IndexOf(currName);
                                names.Insert(index, currName);
                            }
                            break;
                        case "Length":
                            int length = int.Parse(commands[2]);
                            var currLengt = names.Where(name => lengthFunc(name, length))
                                .ToList();
                            foreach (var currName in currLengt)
                            {
                                int index = names.IndexOf(currName);
                                names.Insert(index, currName);
                            }
                            break;
                    }
                }
                else if (theCommand == "Remove")
                {
                    switch (criteria)
                    {
                        case "StartsWith":
                            string str = commands[2];
                            names = names.Where(name => !startsWithFunc(name, str))
                                .ToList();
                            break;
                        case "EndsWith":
                            string str2 = commands[2];
                            names = names.Where(name => !endsWithFunc(name, str2))
                                .ToList();
                            break;
                        case "Length":
                            int length = int.Parse(commands[2]);
                            names = names.Where(name => !lengthFunc(name, length))
                                .ToList();
                            break;
                    }
                }

                command = Console.ReadLine();
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(String.Join(", ", names));
                Console.WriteLine(" are going to the party!");
            }
        }
    }
}
