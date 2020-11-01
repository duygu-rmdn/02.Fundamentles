using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> namesAndKms = new Dictionary<string, int>();
            string[] peoples = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                string nameParrern = "[A-Za-z]";
                string Digitparrern = @"\d";
                var nameMatches = Regex.Matches(input, nameParrern);
                var kms = Regex.Matches(input, Digitparrern);
                string name = String.Concat(nameMatches);
                var sumOfKms = kms.Select(x => int.Parse(x.Value)).Sum();

                if (peoples.Contains(name))
                {
                    if (namesAndKms.ContainsKey(name))
                    {
                        namesAndKms[name] += sumOfKms;
                    }
                    else
                    {
                        namesAndKms.Add(name, sumOfKms);

                    }


                }

                input = Console.ReadLine();
            }

            var sorted = namesAndKms.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

            Console.WriteLine("1st place: " + sorted[0]);
            Console.WriteLine("2nd place: " + sorted[1]);
            Console.WriteLine("3rd place: " + sorted[2]);
        }                                  
    }
}
