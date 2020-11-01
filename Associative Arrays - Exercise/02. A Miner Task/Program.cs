using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> pairs = new Dictionary<string, int>();
            while (true)
            {
                string resourse = Console.ReadLine();
                if (resourse == "stop")
                {
                    break;
                }
                else
                {
                    int quantity = int.Parse(Console.ReadLine());
                    if (!pairs.ContainsKey(resourse))
                    {
                        pairs.Add(resourse, quantity);
                    }
                    else
                    {
                        pairs[resourse] += quantity;
                    }

                }


            }
            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
