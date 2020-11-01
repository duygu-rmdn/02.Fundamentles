using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (counter == 3)
                {
                    break;
                }
                Console.Write(nums[i] + " ");
                counter++;
            }

          
        }
    }
}
