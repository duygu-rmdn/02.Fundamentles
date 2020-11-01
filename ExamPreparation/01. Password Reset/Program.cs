using System;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] splited = command.Split();
                string operation = splited[0];

                if (operation == "TakeOdd")
                {
                    string newPass = "";
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            newPass += password[i];
                        }
                    }
                    password = newPass;
                    Console.WriteLine(password);
                }
                else if (operation == "Cut")
                {
                    int index = int.Parse(splited[1]);
                    int lenght = int.Parse(splited[2]);

                    password = password.Remove(index, lenght);
                    Console.WriteLine(password);
                }
                else if (operation == "Substitute")
                {
                    string substring = splited[1];
                    string substitute = splited[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
