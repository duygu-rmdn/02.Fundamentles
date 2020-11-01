using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> wordsToPrint = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordToLower = word.ToLower();

                if (wordsToPrint.ContainsKey(wordToLower))
                {
                    wordsToPrint[wordToLower]++;
                }
                else
                {
                    wordsToPrint.Add(wordToLower, 1);
                }
            }
            foreach (var item in wordsToPrint)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }


        }
    }
}
