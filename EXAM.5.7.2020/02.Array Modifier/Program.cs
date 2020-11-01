using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] input = line.Split();
                string command = input[0];
                if (command == "swap")
                {
                    int tokens1 = int.Parse(input[1]);
                    int tokens2 = int.Parse(input[2]);
                    int item = nums[tokens1];
                    nums[tokens1] = nums[tokens2];
                    nums[tokens2] = item;
                }
                else if (command == "multiply")
                {
                    int tokens1 = int.Parse(input[1]);
                    int tokens2 = int.Parse(input[2]);
                    nums[tokens1] = nums[tokens1] * nums[tokens2];

                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums[i] -= 1;
                    }
                }
                line = Console.ReadLine();

            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
