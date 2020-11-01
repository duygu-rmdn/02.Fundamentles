using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int currNum = nums[i];
                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
