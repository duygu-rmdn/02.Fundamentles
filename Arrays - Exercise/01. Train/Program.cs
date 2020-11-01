using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] peoples = new int[wagons];
            int sum = 0;
            for (int i = 0; i < wagons ; i++)
            {
                peoples[i] = int.Parse(Console.ReadLine());
                sum += peoples[i];
            }
            Console.WriteLine(String.Join(' ', peoples));
            Console.WriteLine(sum);
        }
    }
}
