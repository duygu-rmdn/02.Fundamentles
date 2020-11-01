using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double peopleCount = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double coureses = peopleCount / capacity;
            Console.WriteLine(Math.Ceiling(coureses));
        }
    }
}
