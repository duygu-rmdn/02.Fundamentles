using System;
using System.Collections.Generic;
using System.Linq;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> output = new List<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                var curr = input[i];
                for (int j = 0; j < curr.Length; j++)
                {
                    if (curr[j] != ' ')
                    {
                        output.Add(curr[j].ToString());
                    }
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
