using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfFilters = new List<string>(); 

            List<string> names = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();
            while (input != "Print")
            {

                string[] commands = input.Split(";", StringSplitOptions.RemoveEmptyEntries);

                string[] filter = commands[0].Split();
                string command = filter[0];

                string typeFilter = commands[1];

                string argument = commands[2];

                if(command == "Add")
                {
                    listOfFilters.Add($"{typeFilter} {argument}");
                }
                else if(command == "Remove")
                {
                    listOfFilters.Remove($"{typeFilter} {argument}");
                }

                input = Console.ReadLine();
            }

            foreach (var filterLine in listOfFilters)
            {
                string[] command = filterLine.Split();
                string filter = command[0];
                
                //Starts with P
                switch (filter)
                {
                    case "Starts":
                        string argument = command[2];
                        names = names.Where(n => !n.StartsWith(argument)).ToList();
                        break;
                    case "Ends":
                        argument = command[2];
                        names = names.Where(n => !n.EndsWith(argument)).ToList();
                        break;
                    case "Length":
                        argument = command[1];
                        names = names.Where(n => n.Length != int.Parse(argument)).ToList();
                        break;
                    case "Contains":
                        argument = command[1];
                        names = names.Where(n => !n.Contains(argument)).ToList();
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", names));
        }

    }
}
