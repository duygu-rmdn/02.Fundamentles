using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string reversedLine = "";

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversedLine += line[i];
                }

                Console.WriteLine($"{line} = {reversedLine}");
            }
            


        }
    }
}
