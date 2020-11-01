using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                output += (char)(input[i] + 3);
            }
            Console.WriteLine(output);
        }
    }
}
