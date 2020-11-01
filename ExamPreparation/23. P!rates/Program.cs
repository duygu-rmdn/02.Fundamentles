using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace _23._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> countries = new Dictionary<string, List<int>>();

            string command1 = Console.ReadLine();
            
            while (command1 != "Sail")
            {
                string[] splited = command1.Split("||");
                string country = splited[0];
                int population = int.Parse(splited[1]);
                int gold = int.Parse(splited[2]);

                if (countries.ContainsKey(country))
                {
                    countries[country][0] += population;
                    countries[country][1] += gold;
                }
                else
                {
                    countries.Add(country, new List<int>() { population, gold });
                }
                command1 = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splited = command.Split("=>");
                string operation = splited[0];
                string town = splited[1];

                if (operation == "Plunder")
                {
                    int people = int.Parse(splited[2]);
                    int gold = int.Parse(splited[3]);
                    
                    countries[town][0] -= people;
                    countries[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (countries[town][0] == 0|| countries[town][1] == 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        countries.Remove(town);
                    }
                }
                else if (operation == "Prosper")
                {
                    int gold = int.Parse(splited[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        countries[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {countries[town][1]} gold.");
                    }
                }
                command = Console.ReadLine();
            }
            if (countries.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                var ordered = countries.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key);
                Console.WriteLine($"Ahoy, Captain! There are {countries.Count} wealthy settlements to go to:");
                foreach (var item in ordered)
                {
                    Console.WriteLine($"{item.Key} -> Population: { item.Value[0]} citizens, Gold: { item.Value[1]} kg");
                }
            }
        }
    }
}
