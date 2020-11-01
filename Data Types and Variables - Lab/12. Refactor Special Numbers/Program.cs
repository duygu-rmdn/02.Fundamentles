using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine()); 

            for (byte i = 1; i <= n; i++)
            {
                int sum = 0;
                int digit = i;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
