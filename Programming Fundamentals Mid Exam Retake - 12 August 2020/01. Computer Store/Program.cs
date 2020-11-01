using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double price = 0.0;
            double sum = 0.0;
            double taxes = 0.0;
            string type = "";
            while (command != "special" && command != "regular")
            {
                price = double.Parse(command);
                if (price >= 0)
                {
                    sum += price;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }

                command = Console.ReadLine();
                type = command.ToString();
            }
            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");

            }
            else
            {
                taxes = sum * 0.2;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                double total = sum + taxes;
                if (type == "special")
                {
                    total *= 0.9;
                }
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {total:f2}$");
            }
        }
    }
}
