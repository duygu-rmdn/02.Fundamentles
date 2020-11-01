using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = "";
            double biggestKeg = int.MinValue;
            string biggestKegName = "";
            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double size = Math.PI * Math.Pow(radius, 2)* height;
                if (size > biggestKeg)
                {
                    biggestKeg = size;
                    biggestKegName = name;
                }
                
            }
            Console.WriteLine(biggestKegName);

        }
    }
}
