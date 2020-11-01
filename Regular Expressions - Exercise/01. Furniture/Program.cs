using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @">>([A-Za-z]+)<<(\d+\.?\d*)!(\d+)";
            double sum = 0.0;
            List<string> furnitires = new List<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Purchase")
                {
                    break;
                }

                Regex regex = new Regex(pattern);
                Match match = regex.Match(command);

                if (match.Success)
                {
                    furnitires.Add(match.Groups[1].Value);
                    sum += double.Parse(match.Groups[2].Value) * double.Parse(match.Groups[3].Value);
                }


            }
            Console.WriteLine("Bought furniture:");
            if (sum > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, furnitires));
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
