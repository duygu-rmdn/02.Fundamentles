using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split();
                if (tokens[0] == "Add")
                {
                    int tolen1 = int.Parse(tokens[1]);
                    nums.Add(tolen1);
                }
                else if (tokens[0] == "Remove")
                {
                    int tolen1 = int.Parse(tokens[1]);
                    nums.Remove(tolen1);
                }
                else if (tokens[0] == "RemoveAt")
                {
                    int tolen1 = int.Parse(tokens[1]);
                    nums.RemoveAt(tolen1);
                }
                else if (tokens[0] == "Insert")
                {
                    int tolen1 = int.Parse(tokens[1]);
                    int tolen2 = int.Parse(tokens[2]);
                    nums.Insert(tolen2, tolen1);
                }

            }
            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
