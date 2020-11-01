using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
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
            while (line != "end")
            {
                string[] tokens = line.Split();
                int token1 = int.Parse(tokens[1]);

                if (tokens[0] == "Delete")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                            nums.Remove(token1);
                    }
                }
                else if (tokens[0] == "Insert")
                {
                    int token2 = int.Parse(tokens[2]);
                    nums.Insert(token2, token1);
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
