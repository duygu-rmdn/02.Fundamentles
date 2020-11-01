using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(@|#)([A-Za-z]{3,})(\1)(\1)([A-Za-z]{3,})(\1)";
            var input = Console.ReadLine();
            
            var matches = Regex.Matches(input, pattern);
            List<string> mirrorwords = new List<string>();
            foreach (Match item in matches)
            {
                var word1 = item.Groups[2].Value;
                var word2 = item.Groups[5].Value;


                var reversed = new string(word1.Reverse().ToArray());
                if (reversed == word2)
                {
                    mirrorwords.Add(word1 + " <=> " + word2);
                }
            }
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            if (mirrorwords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorwords));
            }
        }
    }
}
