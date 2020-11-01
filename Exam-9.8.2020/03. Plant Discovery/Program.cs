using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class PlantInfo
    {
        public int Rarity { get; set; }

        public List<double> Rating { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, PlantInfo> plants = new Dictionary<string, PlantInfo>();

            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split("<->");
                string plantName = information[0];
                int rarity = int.Parse(information[1]);

                PlantInfo plant = new PlantInfo() { Rarity = rarity, Rating = new List<double>() };
                if (plants.ContainsKey(plantName))
                {
                    plants[plantName].Rarity = rarity;
                }
                else
                {
                    plants.Add(plantName, plant);
                }

            }


            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                string[] splited = command.Split(": ");
                string operation = splited[0];
                string[] split1 = splited[1].Split(" - ");
                string cuurPlant = split1[0];

                if (operation == "Rate")
                {
                    int rating = int.Parse(split1[1]);
                    if (plants.ContainsKey(cuurPlant))
                    {
                        plants[cuurPlant].Rating.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (operation == "Update")
                {
                    int rarity = int.Parse(split1[1]);
                    if (plants.ContainsKey(cuurPlant))
                    {
                        plants[cuurPlant].Rarity = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (operation == "Reset")
                {
                    if (plants.ContainsKey(cuurPlant))
                    {
                        plants[cuurPlant].Rating.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
                command = Console.ReadLine();
            }

            foreach (var item in plants)
            {
                double averege = 0.0;
                int counter = 0;
                if (item.Value.Rating.Count == 0)
                {
                    item.Value.Rating.Add(0.0);
                }
                foreach (var av in item.Value.Rating)
                {
                    averege += av;
                    counter++;
                }
                averege /= counter;
                item.Value.Rating.Clear();
                item.Value.Rating.Add(averege);
            }

            var ordered = plants.OrderByDescending(plant => plant.Value.Rarity).ThenByDescending(plant => plant.Value.Rating.Average()).ToDictionary(item => item.Key, item => item.Value);

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in ordered)
            {
                if (item.Value.Rating.Count == 0)
                {
                    item.Value.Rating.Add(0.0);
                }

                double rat = item.Value.Rating.Average();

                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {rat:f2}");
            }



        }
    }
}
