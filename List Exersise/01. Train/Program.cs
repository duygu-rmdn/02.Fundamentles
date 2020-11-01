﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            while (true)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();
                if (line == "end")
                {
                    break;
                }
                if (tokens[0] == "Add")
                {
                    int passengers = int.Parse(tokens[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(tokens[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }

                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
