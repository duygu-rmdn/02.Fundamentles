using System;
using System.Runtime.CompilerServices;

namespace _21._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Generate")
            {
                string[] splted = command.Split(">>>");
                string operation = splted[0];

                if (operation == "Contains")
                {
                    string substring = splted[1];

                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (operation == "Flip")
                {
                    string upperOrLower = splted[1];
                    int startIndex = int.Parse(splted[2]);
                    int endIndex = int.Parse(splted[3]);
                    string old = "";
                    string repleace = "";
                    if (upperOrLower == "Upper")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            old += key[i];
                            repleace += char.ToUpper(key[i]);
                        }
                        key = key.Replace(old, repleace);
                    }
                    else
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            old += key[i];
                            repleace += char.ToLower(key[i]);
                        }
                        key = key.Replace(old, repleace);
                    }
                    Console.WriteLine(key);
                }
                else if (operation == "Slice")
                {
                    int startIndex = int.Parse(splted[1]);
                    int endIndex = int.Parse(splted[2]);
                    int count = endIndex - startIndex;
                    key = key.Remove(startIndex, count);
                    Console.WriteLine(key);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
