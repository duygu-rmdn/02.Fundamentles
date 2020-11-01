using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();
            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sum1 = first.Sum();
            int sum2 = second.Sum();
            int counter = 0;
            while (sum2 > 0 && sum1 > 0)
            {
                if (first[counter] > second[counter])
                {
                    first.Add(first[counter]);
                    first.Add(second[counter]);
                    
                    sum1 += second[counter];
                    sum2 -= second[counter];
                }
                else if (first[counter] < second[counter])
                {
                    second.Add(second[counter]);
                    second.Add(first[counter]);

                    sum2 += first[counter];
                    sum1 -= first[counter];
                }
                else
                {
                    sum1 -= first[counter];
                    sum2 -= first[counter];
                }
                counter++;
            }
            if (sum1 > 0)
            {
                Console.WriteLine($"First player wins! Sum: {sum1}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {sum2}");
            }
        }
    }
}
