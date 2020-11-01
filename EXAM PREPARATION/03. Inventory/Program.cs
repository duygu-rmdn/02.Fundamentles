using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = Console.ReadLine();
            while (command != "Craft!")
            {
                string[] tokens = command.Split(" - ");
                string operation = tokens[0];
                string item2 = tokens[1];
                if (operation == "Collect")
                {
                    if (!items.Contains(item2))
                    {
                        items.Add(item2);
                    }
                }
                else if (operation == "Drop")
                {
                    if (items.Contains(item2))
                    {
                        items.Remove(item2);
                    }
                }
                else if (operation == "Combine Items")
                {
                    string[] token3 = tokens[1].Split(":");
                    string oldItem = token3[0];
                    string NewItem = token3[1];

                    if (items.Contains(oldItem))
                    {
                        int n = items.IndexOf(oldItem );
                        items.Insert(n + 1, NewItem);
                    }
                }
                else if (operation == "Renew")
                {
                    if (items.Contains(item2))
                    {
                        items.Remove(item2);
                        items.Add(item2);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
