using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbol = char.Parse(Console.ReadLine());

            int num = (int)simbol;

            if (num >= 60 && num <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (num >= 97 && num <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
