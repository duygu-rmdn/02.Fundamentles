using System;

namespace _31._Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "For Azeroth")
            {
                string[] splited = command.Split();
                string operation = splited[0];

                if (operation == "GladiatorStance")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (operation == "DefensiveStance")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (operation == "Dispel")
                {
                    int index = int.Parse(splited[1]);
                    string letter = splited[2];
                    if (index < text.Length)
                    {
                        char[] newCh = letter.ToCharArray();
                        text = text.Replace(text[index], newCh[0]);
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }
                else if (operation == "Target")
                {
                    string todo = splited[1];
                    string substring = splited[2];
                    if (todo == "Change")
                    {
                        string secondsubstring = splited[3];
                        text = text.Replace(substring, secondsubstring);
                        Console.WriteLine(text);
                    }
                    else if (todo == "Remove")
                    {
                        text = text.Remove(text.IndexOf(substring), substring.Length);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
                command = Console.ReadLine();
            }
        }
    }
}
