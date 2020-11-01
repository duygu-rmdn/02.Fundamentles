using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> output = new List<string>();


            for (int i = input.Length; i > -1; i--)
            {
                Console.WriteLine(input);
            }





        }
    }
}
