using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> even = nums;
            List<int> odd = nums;

            even.RemoveAll(n => n % 2 == 0);
            odd.RemoveAll(n => n % 2 == 1);

            while (true)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();
                if (line == "end")
                {
                    break;
                }
                if (tokens[0] == "Contains")
                {
                    int tokens1 = int.Parse(tokens[1]);
                    if (nums.Contains(tokens1))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (tokens[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", even));
                }
            }

        }
    }
}
