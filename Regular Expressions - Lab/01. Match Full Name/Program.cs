﻿using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection matchedRegex = Regex.Matches(names, regex);

            foreach (Match match in matchedRegex)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
