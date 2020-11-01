using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"((?:=|\/))([A-Z][A-Za-z]{2,})(\1)";
            List<string> destinations = new List<string>();
            var matches = Regex.Matches(text, pattern);

            string destinationPoints = "";

            foreach (Match item in matches)
            {
                destinationPoints += item.Groups[2].Value;
                destinations.Add(item.Groups[2].Value);
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {destinationPoints.Length}");
        }
    }
}
