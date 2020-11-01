using System;
using System.Text.RegularExpressions;

namespace Regular_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Regex regex = new Regex(@"(\d{2})(\W)(\w*)(\2)(\d{4})");
            var maches = regex.Match(input);
            foreach (Match date in maches)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[5]}");
            }



            //string input = Console.ReadLine();
            //Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            //MatchCollection names = regex.Matches(input);
            //foreach (Match item in names)
            //{
            //    Console.Write(item.Value + " ");
            //}



            //Regex regex = new Regex(@"\d{2}(\W)\w*(\1)\d{4}");
            //Match maches = regex.Match(@"12-j-2020 12/Jan/2020 12\Jan\2020");

            //foreach (Match mach in maches)
            //{
            //    Console.WriteLine(maches.Value);
            //    Console.WriteLine(maches.Groups[1].Value);
            //}
        }
    }
}
