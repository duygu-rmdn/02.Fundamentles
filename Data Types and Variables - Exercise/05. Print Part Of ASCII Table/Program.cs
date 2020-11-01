using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int stratingNum = int.Parse(Console.ReadLine());
            int endingNum = int.Parse(Console.ReadLine());

            for (int i = stratingNum; i <= endingNum; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
