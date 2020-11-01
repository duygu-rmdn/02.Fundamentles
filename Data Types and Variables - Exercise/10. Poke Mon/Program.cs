using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int energi = N;
            int counter = 0;
            while (N >= M)
            {
                N -= M;
                counter++;
                if (N * 2 == energi)
                {
                    if (Y > 0)
                    {
                        N /= Y;
                    }
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(counter);

        }
    }
}
