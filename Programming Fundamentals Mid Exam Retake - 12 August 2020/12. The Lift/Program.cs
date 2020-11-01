using System;
using System.Linq;

namespace _12._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < wagons.Length; i++)
            {
                if (waitingPeople > 0)
                {
                    if (wagons[i] < 4)
                    {
                        int marker = 4;
                        if (waitingPeople < 4)
                        {
                            marker = waitingPeople;
                        }
                        int toAdd = marker - wagons[i];
                        wagons[i] += toAdd;
                        waitingPeople -= toAdd;
                    }
                }
                else
                {
                    break;
                }
               
            }
            if (waitingPeople == 0 && wagons[wagons.Length - 1] < 4)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (waitingPeople > 0 && wagons[wagons.Length - 1] == 4)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
            }
            Console.WriteLine(string.Join(" ", wagons));




        }
    }
}
