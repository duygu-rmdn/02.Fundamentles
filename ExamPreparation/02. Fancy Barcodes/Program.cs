using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();

                var matches = Regex.Match(barcode, pattern);

                if (matches.Success)
                {
                    string group = "";
                    for (int j = 0; j < barcode.Length; j++)
                    {
                        if (barcode[j] >= 48 && barcode[j] <= 57)
                        {
                            group += barcode[j];
                        }
                    }
                    if (group == "")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {group}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
