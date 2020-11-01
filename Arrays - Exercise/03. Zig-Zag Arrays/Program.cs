using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] oddPosision = new int[n];
            int[] evenPosision = new int[n];
               
            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 1)
                {
                    oddPosision[i] += nums[1];
                    evenPosision[i] += nums[0];
                }
                else
                {
                    evenPosision[i] += nums[1];
                    oddPosision[i] += nums[0];
                }

            }
            Console.WriteLine(String.Join(" ", oddPosision));
            Console.WriteLine(String.Join(" ", evenPosision));
        }
    }
}
