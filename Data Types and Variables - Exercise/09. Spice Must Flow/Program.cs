using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint yield = uint.Parse(Console.ReadLine());

            uint totalYield = 0;
            int counter = 0;

            while (yield >= 100)
            {
                totalYield += yield;
                yield -= 10;
                counter++;
                totalYield -= 26;
            }
            if (yield >= 26)
            {
            totalYield -= 26;
            }
            if (yield <= 0)
            {
                yield = 0;
            }
            Console.WriteLine(counter);
            Console.WriteLine(totalYield);

          

        }
    }
}
