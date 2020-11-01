using System;
using System.Linq;
using System.Security;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int maxLenght = 0;
            int lenght = 1;

            int start = 0;
            int beststart = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                    start = i;
                }
                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    beststart = start;
                }

            }
            for (int i = beststart; i < beststart + maxLenght; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}

