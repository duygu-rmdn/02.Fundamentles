using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Lab
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> list = Console.ReadLine().Split().ToList();

            list.Contains("1");
            list.Reverse();
            

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
