using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int sumOfEven = 0;
            int sumOfOdd = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int currNum = nums[i];
                if (currNum % 2 == 0)
                {
                    sumOfEven += currNum;
                }
                else
                {
                    sumOfOdd += currNum;
                }
            }
            int substract = sumOfEven - sumOfOdd;
            Console.WriteLine(substract);
        }
    }
}
