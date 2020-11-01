using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            int lightsabresCount = (int)Math.Ceiling(studentsCount * 0.10);
            int counter = 0;
            int belsCount = studentsCount;
            for (int i = 1; i <= studentsCount; i++)
            {
                if (i % 6 == 0)
                {
                    counter++;
                }
            }
            belsCount -= counter;
            double totalPrice = lightsabers*(studentsCount + lightsabresCount);
            totalPrice += studentsCount * robes;
            totalPrice +=  belsCount * belts;
            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice- money):f2}lv more.");
            }
        }
    }
}
