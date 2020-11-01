using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int element1 = nums[0];
                int[] temp = new int[nums.Length];
                for (int j = 1; j < temp.Length; j++)
                {
                    temp[j - 1] = nums[j];
                }
                temp[temp.Length - 1] = element1;
                nums = temp;
            }
            Console.WriteLine(String.Join(' ', nums));
        }
    }
}
