using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            bool print = true;
            while (command != "Reveal")
            {
                string[] splited = command.Split(":|:");
                string operation = splited[0];

                if (operation == "InsertSpace")
                {
                    int index = int.Parse(splited[1]);
                    message = message.Insert(index, " ");
                }
                else if (operation == "Reverse")
                {
                    string substring = splited[1];
                    if (message.Contains(substring))
                    {
                        int startIndex = message.IndexOf(substring);
                        message = message.Remove(startIndex, substring.Length);
                        string newStr = "";
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            newStr += substring[i];
                        }
                        message += newStr;

                    }
                    else
                    {
                        Console.WriteLine("error");
                        print = false;
                    }
                    
                }
                else if (operation == "ChangeAll")
                {
                    string substring = splited[1];
                    string replacement = splited[2];

                    message = message.Replace(substring, replacement);
                }
                if (print)
                {
                    Console.WriteLine(message);
                }
                print = true;
                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
