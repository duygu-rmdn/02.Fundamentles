using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace _22._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((?:\*\*|::))([A-Z][a-z]{2,})(\1)";
            string text = Console.ReadLine();

            BigInteger threshold = 1;


            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    int curr = int.Parse(text[i].ToString());
                    threshold *= curr;
                }
            }

            var matches = Regex.Matches(text, pattern);
            
            int count = matches.Count;
            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{count} emojis found in the text. The cool ones are:");
            foreach (Match item in matches)
            {
                int values = 0;
                var curr = item.Groups[2].Value;
                for (int i = 0; i < curr.Length; i++)
                {
                    values += curr[i];
                }
                if (values > threshold)
                {
                    Console.WriteLine(item.Value);
                }


            }


        }
    }
}
