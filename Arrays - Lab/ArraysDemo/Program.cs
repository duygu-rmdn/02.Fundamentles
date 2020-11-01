using System;
using System.Linq;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }

        }
    }
}
