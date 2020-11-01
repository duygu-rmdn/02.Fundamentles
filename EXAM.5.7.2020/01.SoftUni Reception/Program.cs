using System;

namespace _01.SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            byte first = byte.Parse(Console.ReadLine());
            byte second = byte.Parse(Console.ReadLine());
            byte third = byte.Parse(Console.ReadLine());

            int studenstsCount = int.Parse(Console.ReadLine());

            int sum = first + second + third;
            double counter = 0;

            counter = Math.Ceiling(studenstsCount * 1.0 / sum);

            for (int i = 1; i <= counter; i++)
            {
                if (i % 4 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
