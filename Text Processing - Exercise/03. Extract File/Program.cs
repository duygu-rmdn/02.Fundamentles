using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] splited = input.Split("\\").ToArray();

            string[] nameAndExtension = (splited[splited.Length - 1]).ToString().Split(".");
            Console.WriteLine("File name: " + nameAndExtension[0]);
            Console.WriteLine("File extension: " + nameAndExtension[1]);

        }
    }
}
