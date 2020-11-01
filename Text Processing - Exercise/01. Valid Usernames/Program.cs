using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var validUserNames = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                if (current.Length > 2 && current.Length < 17)
                {
                    bool isValid = true;

                    for (int j = 0; j < current.Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(current[j]) || current[j] == '-' || current[j] == '_'))
                        {
                            isValid = false;
                        }
                    }
                    if (isValid)
                    {
                        validUserNames.Add(current);
                    }
                }

            }
            Console.WriteLine(String.Join(Environment.NewLine, validUserNames));
        }
    }
}
