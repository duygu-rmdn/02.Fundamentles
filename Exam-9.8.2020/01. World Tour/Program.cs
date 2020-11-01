using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Travel")
            {
                string[] splited = command.Split(":");
                string operation = splited[0];

                if (operation == "Add Stop")
                {
                    int index = int.Parse(splited[1]);
                    string substring = splited[2];

                    if (index > -1 && index <= text.Length)
                    {
                        text = text.Insert(index, substring);
                    }
                    Console.WriteLine(text);
                }
                else if (operation == "Remove Stop")
                {
                    int startIndex = int.Parse(splited[1]);
                    int endIndex = int.Parse(splited[2]);
                    if (startIndex > -1 && startIndex <= text.Length && endIndex > -1 && endIndex < text.Length)
                    {
                        int count = endIndex - startIndex + 1;
                        text = text.Remove(startIndex, count);
                    }
                    Console.WriteLine(text);
                }
                else if (operation == "Switch")
                {
                    string old = splited[1];
                    string newS = splited[2];

                    if (text.Contains(old))
                    {
                        text = text.Replace(old, newS);
                    }
                    Console.WriteLine(text);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
