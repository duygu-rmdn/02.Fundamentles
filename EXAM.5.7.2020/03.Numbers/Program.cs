using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double avr = nums.Average();
            List<int> bigNums = new List<int>();
            bool no = true;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > avr)
                {
                    bigNums.Add(nums[i]);
                    no = false;
                }
                
            }
            int counter = 0;
            for (int i = bigNums.Count; i > 0; i--)
            {
                int n = bigNums.Max();
                no = false;

                Console.Write(n + " ");
                counter++;
                if (counter > 4)
                {
                    break;
                }
                bigNums.Remove(bigNums.Max());
            }


            if (no)
            {
                Console.WriteLine("No");
            }

        }
    }
}
