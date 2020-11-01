using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            string line = Console.ReadLine();
            string[] tokens = line.Split();
            int bombNum = int.Parse(tokens[0]);
            int power = int.Parse(tokens[1]);
            int index = nums.IndexOf(bombNum);

            while (index != -1)
            {
                int left = index - power;
                int right = index + power;
                if (left < 0 )
                {
                    left = 0;
                }
                if (right > nums.Count- 1)
                {
                    right = nums.Count - 1;
                }
                nums.RemoveRange(left, right - left + 1);

                index = nums.IndexOf(bombNum);
            }
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
