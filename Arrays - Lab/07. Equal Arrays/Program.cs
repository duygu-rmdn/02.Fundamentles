using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNums = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            int[] secondNums = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            bool identikal = true;
            bool sing = false;
            int sum = 0;
            for (int i = 0; i < firstNums.Length; i++)
            {
                int curNum = firstNums[i];
                if (firstNums[i] != secondNums[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    sing = true;
                    identikal = false;
                    break;
                }
                 else if (identikal)
                {
                    identikal = true;
                    sum += curNum;
                }
                if (sing)
                {
                    break;
                }
            }
            if (identikal)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
