using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> characters = new Dictionary<char, int>();


            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (symbol == 32)
                {
                    continue;
                }
                if (!characters.ContainsKey(symbol))
                {
                    characters.Add(symbol, 1);
                }
                else
                {
                    characters[symbol]++;
                }
            }

            foreach (var item in characters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
