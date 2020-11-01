using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int lastDigit = (num - (num / 10)  *10);

            string lastDigitname = "";
            if (lastDigit == 1)
            {
                lastDigitname = "one";
            }
            else if (lastDigit == 2)
            {
                lastDigitname = "two";
            }
            else if (lastDigit == 3)
            {
                lastDigitname = "three";
            }
            else if (lastDigit == 4)
            {
                lastDigitname = "four";
            }
            else if (lastDigit == 5)
            {
                lastDigitname = "five";
            }
            else if (lastDigit == 6)
            {
                lastDigitname = "six";
            }
            else if (lastDigit == 7)
            {
                lastDigitname = "seven";
            }
            else if (lastDigit == 8)
            {
                lastDigitname = "eight";
            }
            else if (lastDigit == 9)
            {
                lastDigitname = "nine";
            }

            Console.WriteLine(lastDigitname);
        }
    }
}
