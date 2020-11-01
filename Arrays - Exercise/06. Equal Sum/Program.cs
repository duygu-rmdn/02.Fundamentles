using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;
            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    rightSum += nums[j];
                }
                for (int k = 0; k < i; k++)
                {
                    leftSum += nums[k];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
                
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
