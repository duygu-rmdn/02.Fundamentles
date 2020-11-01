using System;
using System.Collections.Generic;

namespace ASSOCIATIVE_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary["Duygu"] = 15;
            dictionary["Simon"] = 12;
            dictionary["Jonh"] = 13;

            dictionary.Add("Martin", 14);
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            dictionary.Remove("Duygu");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            //int[] nums = Console.ReadLine()
            //    .Split()
            //    .Where(w => w.Length < 4)
            //    .Select(int.Parse)
            //    .OrderByDescending(n => n)
            //    .ToArray();


            //Console.WriteLine(String.Join(" ", nums));
        }
    }
}
