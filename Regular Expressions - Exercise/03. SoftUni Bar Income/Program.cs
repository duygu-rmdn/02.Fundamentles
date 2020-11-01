using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(([^$.%1-9]+)?)%([A-Z][a-z]+)%(([^$.%1-9]+)?)<(\w+)>(([^$.%]+)?)\|(([^$.%1-9]+)?)(\d+)(([^$.%1-9]+)?)\|(([^$.%1-9]+)?)(([^$.%1-9]+)?)(\d+\.?\d+)(([^$.%1-9]+)?)\$";
            var sum = 0.0;
            var command = Console.ReadLine();
            while (command != "end of shift")
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(command);

                if (match.Success)
                {
                    double totalPrice = double.Parse(match.Groups[11].Value) * double.Parse(match.Groups[18].Value);
                    sum += totalPrice;
                    Console.WriteLine($"{match.Groups[3].Value}: {match.Groups[6].Value} - {totalPrice:f2}");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {sum:f2}");

        }
    }
}
