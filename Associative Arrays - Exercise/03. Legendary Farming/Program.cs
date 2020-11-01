using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            //DOES NOT WORK :(
            string[] input = Console.ReadLine().Split().ToArray();
            int currQuantity = 0;
            string currProduct = String.Empty;


            Dictionary<string, int> farming = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    currQuantity = int.Parse(input[i]);
                }
                else
                {
                    currProduct = input[i].ToLower();
                }
                if (i % 2 == 1)
                {

                    if (farming.ContainsKey(currProduct))
                    {
                        farming[currProduct] += currQuantity;
                    }
                    else
                    {
                        farming.Add(currProduct, currQuantity);
                    }
                }


            }
            if (farming["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                farming["shards"] -= 250;
            }
            else if (farming["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                farming["fragments"] -= 250;
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");
                farming["motes"] -= 250;
            }



            Dictionary<string, int> valid = new Dictionary<string, int>();
            Dictionary<string, int> invalid = new Dictionary<string, int>();
            foreach (var item in farming)
            {
                if (item.Key == "motes")
                {
                    int q = farming["motes"];
                    valid.Add("motes", q);
                }
            }
            foreach (var item in valid)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
