using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] tokens = line.Split();
                string operation = tokens[0];
                string posision = tokens[1];
                if (tokens[0] == "Add")
                {
                    int tokens1 = int.Parse(tokens[1]);
                    nums.Add(tokens1);
                }
                else if (operation == "Insert")
                {
                    int tokens1 = int.Parse(tokens[1]);
                    int tokens2 = int.Parse(tokens[2]);
                    if (tokens2 >= 0 && tokens2 < nums.Count)
                    {
                        nums.Insert(tokens2, tokens1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (operation == "Remove")
                {
                    int tokens1 = int.Parse(tokens[1]);
                    if (tokens1 >= 0 && tokens1 < nums.Count)
                    {
                        nums.RemoveAt(tokens1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (posision == "left")
                {
                    int tokens2 = int.Parse(tokens[2]);
                    for (int i = 0; i < tokens2; i++)
                    {
                        nums.Insert(nums.Count, nums[0]);
                        nums.Remove(nums[0]);
                    }
                }
                else if (tokens[1] == "right")
                {
                    int tokens2 = int.Parse(tokens[2]);
                    for (int i = 0; i < tokens2; i++)
                    {
                        nums.Insert(0, nums[nums.Count - 1]);
                        nums.RemoveAt(nums.Count - 1);
                    }
                }

                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
