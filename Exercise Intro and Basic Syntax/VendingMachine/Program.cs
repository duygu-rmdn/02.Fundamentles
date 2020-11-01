using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            string command = Console.ReadLine();
            while (command != "Start")
            {
                double currA = double.Parse(command);
                if (currA != 0.1 && currA != 0.2 && currA != 0.5 && currA != 1 && currA != 2)
                {
                    Console.WriteLine($"Cannot accept {currA}");
                }
                else
                {
                    totalSum += currA;
                }
                command = Console.ReadLine();
            }

            string item = Console.ReadLine();
            while (item != "End")
            {
                double currPrice = 0;
                switch (item)
                {
                    case "Nuts":
                        currPrice = 2.0;
                        break;
                    case "Water":
                        currPrice = 0.7;
                        break;
                    case "Crisps":
                        currPrice = 1.5;
                        break;
                    case "Soda":
                        currPrice = 0.8;
                        break;
                    case "Coke":
                        currPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        item = Console.ReadLine();
                        continue;
                }

                if (totalSum >= currPrice)
                {
                    totalSum -= currPrice;
                    Console.WriteLine($"Purchased {item.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                item = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalSum:f2}");

        }
    }
}
