using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= n; i++)
            {
                int sumOfDigit = 0;
                int digit = i;
                while (digit > 0)
                {
                    sumOfDigit += digit % 10;
                    digit /= 10;
                }
                bool isSpecial = sumOfDigit == 5 || sumOfDigit == 7 || sumOfDigit == 11;
                Console.WriteLine($"{i} -> {isSpecial}");

            }
        }
    }
}
