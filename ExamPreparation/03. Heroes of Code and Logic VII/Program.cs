using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public int HP { get; set; }

        public int MP { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heros = new Dictionary<string, Hero>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string heroInfo = Console.ReadLine();
                string[] splited = heroInfo.Split();
                string name = splited[0];
                int Hp = int.Parse(splited[1]);
                int Mp = int.Parse(splited[2]);
                Hero hero = new Hero() { HP = Hp, MP = Mp };
                heros.Add(name, hero);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] splited = command.Split(" - ");
                string operation = splited[0];
                string currName = splited[1];

                if (operation == "CastSpell")
                {
                    int neeededMP = int.Parse(splited[2]);
                    string spell = splited[3];
                    if (heros[currName].MP - neeededMP >= 0)
                    {
                        heros[currName].MP -= neeededMP;
                        Console.WriteLine($"{currName} has successfully cast {spell} and now has {heros[currName].MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{currName} does not have enough MP to cast {spell}!");
                    }
                }
                else if (operation == "TakeDamage")
                {
                    int damage = int.Parse(splited[2]);
                    string attacker = splited[3];

                    heros[currName].HP -= damage;
                    if (heros[currName].HP > 0)
                    {
                        Console.WriteLine($"{currName} was hit for {damage} HP by {attacker} and now has {heros[currName].HP} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{currName} has been killed by {attacker}!");
                        heros.Remove(currName);
                    }
                }
                else if (operation == "Recharge")
                {
                    int amount = int.Parse(splited[2]);

                    if (heros[currName].MP + amount > 200)
                    {
                        amount = 200 - heros[currName].MP;
                    }
                    heros[currName].MP += amount;
                    Console.WriteLine($"{currName} recharged for {amount} MP!");
                }
                else if (operation == "Heal")
                {
                    int amount = int.Parse(splited[2]);

                    if (heros[currName].HP + amount > 100)
                    {
                        amount = 100 - heros[currName].HP;
                    }
                    heros[currName].HP += amount;
                    Console.WriteLine($"{currName} healed for {amount} HP!");
                }
                command = Console.ReadLine();
            }

            var survivedNames = heros.OrderByDescending(x => x.Value.HP).ThenBy(x => x.Key);
            foreach (var item in survivedNames)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("  HP: " + item.Value.HP);
                Console.WriteLine("  MP: " + item.Value.MP);
            }
        }
    }
}
