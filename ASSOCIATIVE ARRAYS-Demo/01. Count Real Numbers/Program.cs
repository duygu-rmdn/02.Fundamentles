using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts.Add(num, 1);
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
