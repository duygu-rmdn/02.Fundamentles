using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondNums = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            int maxlenght = Math.Max(firstNums.Count, secondNums.Count);
            List<int> result = new List<int>();
            for (int i = 0; i < maxlenght; i++)
            {
                if (firstNums.Count > i)
                {
                    result.Add(firstNums[i]);
                }
                if (secondNums.Count >i)
                {
                    result.Add(secondNums[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
