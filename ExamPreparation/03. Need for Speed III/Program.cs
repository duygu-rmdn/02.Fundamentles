using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> cars = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string carInfo = Console.ReadLine();
                string[] splited = carInfo.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string carName = splited[0];
                int mileage = int.Parse(splited[1]);
                int fuel = int.Parse(splited[2]);

                cars.Add(carName, new Dictionary<string, int>() {
                    { "mileage", mileage},
                    { "fuel", fuel}
                 });

        }

        string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] splited = command.Split(" : ");
        string operation = splited[0];
        string currCar = splited[1];

                if (operation == "Drive")
                {
                    int distance = int.Parse(splited[2]);
        int neededFuel = int.Parse(splited[3]);

                    if (cars[currCar]["fuel"] < neededFuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[currCar]["mileage"] += distance;
                        cars[currCar]["fuel"] -= neededFuel;
                        Console.WriteLine($"{currCar} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");
                    }
                    if (cars[currCar]["mileage"] > 100000)
                    {
                        Console.WriteLine($"Time to sell the {currCar}!");
                        cars.Remove(currCar);
                    }
                }
                else if (operation == "Refuel")
                {
                    int fuel = int.Parse(splited[2]);
                    if (fuel + cars[currCar]["fuel"] > 76)
                    {
                        fuel = 75 - cars[currCar]["fuel"];
                        cars[currCar]["fuel"] = 75;
                    }
                    else
                    {
                        cars[currCar]["fuel"] += fuel;
                    }
                    Console.WriteLine($"{currCar} refueled with {fuel} liters");
                }
                else if (operation == "Revert")
                {
                    int km = int.Parse(splited[2]);

                    if (cars[currCar]["mileage"] - km< 10000)
                    {
                        cars[currCar]["mileage"] = 10000;
                    }
                    else
                    {
                        cars[currCar]["mileage"] -= km;
                        Console.WriteLine($"{currCar} mileage decreased by {km} kilometers");
                    }
                }
                command = Console.ReadLine();
            }
            var ordered = cars.OrderByDescending(x => x.Value["mileage"]).ThenBy(x => x.Key);
            foreach (var car in ordered)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value["mileage"]} kms, Fuel in the tank: {car.Value["fuel"]} lt.");
            }

        }
    }
}
