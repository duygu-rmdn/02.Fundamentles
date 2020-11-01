using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var datesStr = Console.ReadLine();
            var dates = Regex.Matches(datesStr, regex);

            foreach (Match date in dates)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: { date.Groups["month"].Value}, Year: { date.Groups["year"].Value}");
            }
        }
    }
}
