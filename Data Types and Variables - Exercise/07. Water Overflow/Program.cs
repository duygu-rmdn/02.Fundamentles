using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capasity = 255;
            int litresInTank = 0;
             
            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());

                if ((litres + litresInTank) <= capasity)
                {
                    litresInTank += litres;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(litresInTank);
        }
    }
}
