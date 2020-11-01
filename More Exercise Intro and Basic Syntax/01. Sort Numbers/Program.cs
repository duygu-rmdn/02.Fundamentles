using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int maxNum = Math.Max(Math.Max(num1, num2), num3);
            int minNum = Math.Min(Math.Min(num1, num2), num3);
            int num = 0;

            if (num1 != num2 && num1 != num3 && num3 != num2)
            {
                if (num1 > minNum && num1 < maxNum)
                {
                    num = num1;
                }
                else if (num2 > minNum && num2 < maxNum)
                {
                    num = num2;
                }
                else if (num3 > minNum && num3 < maxNum)
                {
                    num = num3;
                }
            }
            else
            {
                if (num1 >= minNum && num1 <= maxNum)
                {
                    num = num1;
                }
                else if (num2 >= minNum && num2 <= maxNum)
                {
                    num = num2;
                }
                else if (num3 >= minNum && num3 <= maxNum)
                {
                    num = num3;
                }
            }

            Console.WriteLine(maxNum);
            Console.WriteLine(num);
            Console.WriteLine(minNum);

        }
    }
}
