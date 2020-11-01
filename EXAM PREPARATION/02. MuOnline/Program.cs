using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");

            int health = 100;
            int bitcions = 0;
            for (int i = 0; i < rooms.Length; i++)
            {

                string[] line = rooms[i].Split();
                string command = line[0];
                int num = int.Parse(line[1]);

                if (command == "potion")
                {
                    if (health + num > 100)
                    {
                        num = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        health += num;
                    }
                    Console.WriteLine($"You healed for {num} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    bitcions += num;
                    Console.WriteLine($"You found {num} bitcoins.");
                }
                else
                {
                    if (health - num > 0)
                    {
                        health -= num;
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        health -= num;
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }

            }
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcions}");
                Console.WriteLine($"Health: { health}");
            }
        }
    }
}